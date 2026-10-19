using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq.Expressions;

namespace Core.Interfaces;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
}
