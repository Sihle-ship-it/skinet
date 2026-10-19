using System;
using System.Collections.Generic;   
using System.Text;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Core.Specifications;

public class BaseSpecification<T>(Expression<Func<T, bool>> criteria) : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria { get; }
}
