namespace FakeItEasy
{
    using System;
    using FakeItEasy.Configuration;

    /// <summary>
    /// Provides extension methods for <see cref="IArgumentValidationConfiguration{TInterface}"/>.
    /// </summary>
    public static class ArgumentValidationConfigurationExtensions
    {
        /// <summary>
        /// Specifies that a call to the configured call should be applied no matter what arguments
        /// are used in the call to the faked object.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <returns>A configuration object.</returns>
        public static TInterface WithAnyArguments<TInterface>(this IArgumentValidationConfiguration<TInterface> configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.WhenArgumentsMatch(x => true);
        }

        /// <summary>
        /// Configures the call to be accepted when the specified predicate returns true.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <param name="argumentsPredicate">The argument predicate.</param>
        /// <returns>A configuration object.</returns>
        public static TInterface WhenArgumentsMatch<TInterface, T1>(
            this IArgumentValidationConfiguration<TInterface> configuration,
            Func<T1, bool> argumentsPredicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configures the call to be accepted when the specified predicate returns true.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <param name="argumentsPredicate">The argument predicate.</param>
        /// <returns>A configuration object.</returns>
        public static TInterface WhenArgumentsMatch<TInterface, T1, T2>(
            this IArgumentValidationConfiguration<TInterface> configuration,
            Func<T1, T2, bool> argumentsPredicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configures the call to be accepted when the specified predicate returns true.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <param name="argumentsPredicate">The argument predicate.</param>
        /// <returns>A configuration object.</returns>
        public static TInterface WhenArgumentsMatch<TInterface, T1, T2, T3>(
            this IArgumentValidationConfiguration<TInterface> configuration,
            Func<T1, T2, T3, bool> argumentsPredicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configures the call to be accepted when the specified predicate returns true.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <param name="argumentsPredicate">The argument predicate.</param>
        /// <returns>A configuration object.</returns>
        public static TInterface WhenArgumentsMatch<TInterface, T1, T2, T3, T4>(
            this IArgumentValidationConfiguration<TInterface> configuration,
            Func<T1, T2, T3, T4, bool> argumentsPredicate)
        {
            throw new NotImplementedException();
        }
    }
}
