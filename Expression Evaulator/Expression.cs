using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Expression_Evaulator;

public static class Expression
{
    // public static async Task<Func<T, bool>> generateExpression<T>(this string expression)
    // {
    //     var options = ScriptOptions.Default.AddReferences(typeof(T).Assembly);
    //     var filterExpression = await CSharpScript.EvaluateAsync<Func<T, bool>>("t => t." + expression, options);
    //     return filterExpression;
    // }
    
    public static async IEnumerable<TSource> Where<TSource>(string expression)
    {
        var options = ScriptOptions.Default.AddReferences(typeof(TSource).Assembly);
        var generatedExpression  =  CSharpScript.EvaluateAsync<Func<TSource, bool>>("t => t." + expression, options);
        return ???
    }
}