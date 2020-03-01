﻿using ViennaNET.WebApi.Abstractions;
using ViennaNET.WebApi.Configurators.Common;
using ViennaNET.WebApi.Configurators.Diagnostic;
using ViennaNET.WebApi.Configurators.HttpClients.Jwt;
using ViennaNET.WebApi.Configurators.Kestrel;
using ViennaNET.WebApi.Configurators.SimpleInjector;
using ViennaNET.WebApi.Configurators.Swagger;

namespace ViennaNET.WebApi.Runners.BaseKestrel
{
  /// <summary>
  /// Класс для создания и конфигурирования базового сервиса на Kestrel с JWT-аутентификацией
  /// </summary>
  public static class BaseKestrelRunner
  {
    public static ICompanyHostBuilder Configure()
    {
      return CompanyHostBuilder.Create().UseDefaultLogging()
                               .UseKestrel()
                               .UseSimpleInjector()
                               .UseSwagger()
                               .UseJwtHttpClients();
    }
  }
}
