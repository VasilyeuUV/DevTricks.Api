using Autofac;
using DevTricks.Api.Security.LoginService;

namespace DevTricks.Api
{
    /// <summary>
    /// Регистрационный модуль
    /// </summary>
    public class RegistrationModule : Module
    {

        //###############################################################################################################################
        #region Module

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            // - Регистрация сервиса логгирования
            builder.RegisterType<LoginService>()
                .As<ILoginService>()
                .InstancePerDependency();
        }

        #endregion // Module

    }
}
