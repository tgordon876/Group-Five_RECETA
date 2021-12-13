using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaPlus
{
    public class APIcalls 
    {
        public static string Search (int offSet, string searchValue)
        {
            string id = "";
            string url = "";
            string url2 = "";
            string returnValue = "";

            try
            {
                //API call for search recipies

                url2 = $"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/search?query={searchValue}&number=1&offset={offSet}";

                var client = new RestClient(url2);
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
                request.AddHeader("x-rapidapi-key", "14456c3c41msh540af74816ae6a5p199eedjsn4768e53e5b12");
                IRestResponse response = client.Execute(request);

                //parsing out the id from the parent array of results
                dynamic dynamicResult = JsonConvert.DeserializeObject(response.Content);

                //looping recipe id's to get information
                for (int i = 0; i < dynamicResult.results.Count; i++)
                {
                    id = dynamicResult.results[i].id;

                    //adding id into the url for API
                    url = $"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/{id}/information";

                    //API call for Recipie Information using id from search
                    var recipeDetailsClient = new RestClient(url);
                    var recipeDetailsRequest = new RestRequest(Method.GET);
                    recipeDetailsRequest.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
                    recipeDetailsRequest.AddHeader("x-rapidapi-key", "14456c3c41msh540af74816ae6a5p199eedjsn4768e53e5b12");
                    IRestResponse recipeDetailsResponse = recipeDetailsClient.Execute(recipeDetailsRequest);

                    //parsing the API result
                    var recipeDetailsContent = JObject.Parse(recipeDetailsResponse.Content);

                    //parsing out the ingrdients from the parent array
                    dynamic dynamicIngredients = JsonConvert.DeserializeObject(recipeDetailsResponse.Content);

                    //Title
                    returnValue += "Title: " + (string)recipeDetailsContent["title"] + "\n";
                    if (recipeDetailsContent["readyInMinutes"] != null) { returnValue += "Time Needed: " + (string)recipeDetailsContent["readyInMinutes"] + "minutes \n"; }
                    //Description
                    //if (recipeDetailsContent["summary"] != null) { txtBoxBreakfast.Text += "Description: \n" + (string)recipeDetailsContent["summary"] + "\n"; }
                    //Ingridients
                    returnValue += "Ingredients: \n";
                    for (int j = 0; j < dynamicIngredients.extendedIngredients.Count; j++)
                    {
                        returnValue += dynamicIngredients.extendedIngredients[j].originalString + "\n";
                    }
                    //Instructions
                    if (recipeDetailsContent["instructions"] != null) { returnValue += "Instructions: \n" + (string)recipeDetailsContent["instructions"] + "\n\n\n"; }
                }
                return returnValue;
            }
            catch
            {
                return "There is a problem right now, please try again later!";
            }
        }      
    }
}
