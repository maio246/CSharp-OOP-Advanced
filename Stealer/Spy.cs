using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        Type classType = Type.GetType(classToInvestigate);

        FieldInfo[] classFields =
            classType.GetFields(BindingFlags.NonPublic
            | BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.Public);

        object classInstance = Activator.CreateInstance(classType, new object[] { });

        var policePapers = new StringBuilder();
        policePapers.AppendLine($"Class under investigation: {classToInvestigate}");

        foreach (var classField in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            policePapers.AppendLine($"{classField.Name} = {classField.GetValue(classInstance)}");
        }

        return policePapers.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] classFields =
            classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        MethodInfo[] classPublicMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        MethodInfo[] classNonPublicMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var corrections = new StringBuilder();

        foreach (var field in classFields)
        {
            corrections.AppendLine($"{field.Name} must be private!");
        }
        foreach (var publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            corrections.AppendLine($"{publicMethod.Name} have to be private!");
        }
        foreach (var privateMethod in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            corrections.AppendLine($"{privateMethod.Name} have to be public!");
        }
        return corrections.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] classNonPublicMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var revealer = new StringBuilder();
        revealer.AppendLine($"All Private Methods of Class: {className}");
        revealer.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classNonPublicMethods)
        {
            revealer.AppendLine(method.Name);
        }
        return revealer.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        MethodInfo[] classPublicMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        var getters = new StringBuilder();

        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            getters.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            getters.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return getters.ToString().Trim();
    }
}