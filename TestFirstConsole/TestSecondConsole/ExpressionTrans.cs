using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    public class ExpressionTrans
    {
        public static PeopleCopy Trans(People p)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(People), "t");
            NewExpression newExpression = Expression.New(typeof(PeopleCopy));
            List<MemberBinding> bindingList = new List<MemberBinding>()
            {
                //Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(set_Id())), Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(get_Id())))),
                //        Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(set_Name())), Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(get_Name())))),
                //        Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(set_Age())), Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(get_Age()))))
            };
            MemberInitExpression memberInitExpression = Expression.MemberInit(newExpression,bindingList.ToArray());

            Expression<Func<People, PeopleCopy>> expression = Expression.Lambda<Func<People, PeopleCopy>>
            (
                memberInitExpression,
                new ParameterExpression[]
                {
                    parameterExpression
                }
            );

            return expression.Compile().Invoke(p);
        }

        public static List<T> Query<T>(Expression<Func<T, bool>> predicate)
        {
            return default(List<T>);
        }
    }
}
