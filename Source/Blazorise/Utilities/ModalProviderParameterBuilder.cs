﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
#endregion

namespace Blazorise
{
    /// <summary>
    /// Provides a builder with helper methods to help you build your component parameters.
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    public class ModalProviderParameterBuilder<TComponent>
    {
        /// <summary>
        /// Parameters to be passed onto TComponent instantiation.
        /// </summary>
        public Dictionary<string, object> Parameters { get; private set; }

        /// <summary>
        /// Adds a new TComponent parameter.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="selector"></param>
        /// <param name="value"></param>
        public void Add<TValue>( Expression<Func<TComponent, TValue>> selector, TValue value )
        {
            var name = ( ( selector.Body ) as MemberExpression ).Member.Name;
            Add( name, value );
        }

        private void Add( string name, object value )
        {
            Parameters ??= new();
            Parameters.Add( name, value );
        }

    }
}
