﻿using System.Threading;

namespace Science.Mathematics.Algebra
{
    /// <summary>
    /// Represents an algebra expression. Serves as the base class of all expressions.
    /// </summary>
    public abstract class AlgebraExpression
    {
        #region Simple algebraic transformations
        /// <summary>
        /// Simplifies the expression.
        /// </summary>
        /// <returns></returns>
        public abstract AlgebraExpression Simplify();

        /// <summary>
        /// Expands the expression.
        /// </summary>
        /// <returns></returns>
        public abstract AlgebraExpression Expand();

        /// <summary>
        /// Factors the expression.
        /// </summary>
        /// <returns></returns>
        public abstract AlgebraExpression Factor();
        #endregion

        /// <summary>
        /// Computes the constant value of the expression.
        /// </summary>
        /// <returns></returns>
        public abstract double? GetConstantValue();
    }
}