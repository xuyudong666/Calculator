using System;
using System.Collections.Generic;
using System.Linq;
using EnumsNET;

namespace Calculator.Application.Entensions;

public class EnumMember
{
    private EnumMember(string name, object value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; }

    public object Value { get; }

    public IReadOnlyCollection<EnumMember> GetMembers(Type enumType)
    {
        var members = Enums.GetMembers(enumType);

        return members
            .Select(m =>
                new EnumMember(
                    m.AsString(EnumFormat.DisplayName, EnumFormat.Description, EnumFormat.Name)!,
                    m.Value
                )
            )
            .ToArray();
    }
}

public class EnumMember<TEnum> where TEnum : struct, Enum
{
    private EnumMember(string name, TEnum value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; }

    public TEnum Value { get; }

    public static IReadOnlyCollection<EnumMember<TEnum>> GetMembers()
    {
        var members = Enums.GetMembers<TEnum>();

        return members
            .Select(m =>
                new EnumMember<TEnum>(
                    m.AsString(EnumFormat.DisplayName, EnumFormat.Description, EnumFormat.Name)!,
                    m.Value
                )
            )
            .ToList();
    }
}