﻿using System;

namespace ViennaNET.Validation.Rules.FluentRule.RuleValidators
{
  internal class GreaterThanOrEqualValidator<T> : PropertyRuleValidator<T> where T : IComparable
  {
    private readonly T _valueToCompare;

    public GreaterThanOrEqualValidator(T valueToCompare)
    {
      _valueToCompare = valueToCompare;
    }

    protected int Compare(T comparisonValue, T propertyValue) => comparisonValue.CompareTo(_valueToCompare);

    protected override bool IsValid(T instance, ValidationContext context)
    {
      return Compare(instance, _valueToCompare) >= 0;
    }
  }
}
