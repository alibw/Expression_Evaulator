
using Expression_Evaulator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;


var products = new List<Product>
{
    new Product {ProductName = "Speaker", ProductDescription = "Audio",ProductCount = 125},
    new Product {ProductName = "Tv", ProductDescription = "Video",ProductCount = 100},
    new Product {ProductName = "Book", ProductDescription = "Entertainment",ProductCount = 200},
};

string whereExpression = "ProductCount >= 125";
string orderByExpression = "ProductCount";

var result = products
    .Where(whereExpression.generateExpression<Product>().Result)
    .OrderBy(orderByExpression.generateExpression<Product>().Result);

var filteredResult = result;

