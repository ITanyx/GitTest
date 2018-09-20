using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    public class OperatorVisitor : ExpressionVisitor
    {
        public override Expression Visit(Expression node)
        {
            return base.Visit(node);
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            return base.VisitCatchBlock(node);
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            return base.VisitElementInit(node);
        }

        //
        // 摘要:
        //     访问 System.Linq.Expressions.LabelTarget。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            return base.VisitLabelTarget(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.MemberAssignment 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            return base.VisitMemberAssignment(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.MemberBinding 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            return base.VisitMemberBinding(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.MemberListBinding 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            return base.VisitMemberListBinding(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.MemberMemberBinding 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            return base.VisitMemberMemberBinding(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.SwitchCase 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            return base.VisitSwitchCase(node);
        }
       
        //二元表达式
        protected override Expression VisitBinary(BinaryExpression node)
        {
            return base.VisitBinary(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.BlockExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitBlock(BlockExpression node)
        {
            return base.VisitBlock(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.ConditionalExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitConditional(ConditionalExpression node)
        {
            return base.VisitConditional(node);
        }
        
        //常量表达式
        protected override Expression VisitConstant(ConstantExpression node)
        {
            return base.VisitConstant(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.DebugInfoExpression。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            return base.VisitDebugInfo(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.DefaultExpression。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitDefault(DefaultExpression node)
        {
            return base.VisitDefault(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.DynamicExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitDynamic(DynamicExpression node)
        {
            return base.VisitDynamic(node);
        }
        //
        // 摘要:
        //     访问扩展表达式的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitExtension(Expression node)
        {
            return base.VisitExtension(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.GotoExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitGoto(GotoExpression node)
        {
            return base.VisitGoto(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.IndexExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitIndex(IndexExpression node)
        {
            return base.VisitIndex(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.InvocationExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitInvocation(InvocationExpression node)
        {
            return base.VisitInvocation(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.LabelExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitLabel(LabelExpression node)
        {
            return base.VisitLabel(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.Expression`1 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 类型参数:
        //   T:
        //     委托的类型。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            return base.VisitLambda<T>(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.ListInitExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitListInit(ListInitExpression node)
        {
            return base.VisitListInit(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.LoopExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitLoop(LoopExpression node)
        {
            return base.VisitLoop(node);
        }
        
        //成员表达式 例:a.Name
        protected override Expression VisitMember(MemberExpression node)
        {
            return base.VisitMember(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.MemberInitExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            return base.VisitMemberInit(node);
        }
        
        //方法表达式
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            return base.VisitMethodCall(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.NewExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitNew(NewExpression node)
        {
            return base.VisitNew(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.NewArrayExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            return base.VisitNewArray(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.ParameterExpression。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.RuntimeVariablesExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            return base.VisitRuntimeVariables(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.SwitchExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitSwitch(SwitchExpression node)
        {
            return base.VisitSwitch(node);
        }
        //
        // 摘要:
        //     访问 System.Linq.Expressions.TryExpression 的子级。
        //
        // 参数:
        //   node:
        //     要访问的表达式。
        //
        // 返回结果:
        //     如果修改了该表达式或任何子表达式，则为修改后的表达式；否则返回原始表达式。
        protected override Expression VisitTry(TryExpression node)
        {
            return base.VisitTry(node);
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
           return base.VisitTypeBinary(node);
        }
      
        //一元表达式
        protected override Expression VisitUnary(UnaryExpression node)
        {
            return base.VisitUnary(node);
        }
    }
}
