namespace EDocumentProxy;

using System.Text;
using CoreWCF.Channels;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TR.EDocumentEndpoint;

public static class EDocumentEndpointExtensions
{
    /// <summary>
    /// Basicly call <c>.AddServiceModelServices()</c> and <c>.AddServiceModelMetadata()</c> methods from CoreWcf.
    /// </summary>
    /// <param name="serviceCollection">.NET IServiceCollection interface.</param>
    public static void AddEdocumentEndpoint(this IServiceCollection serviceCollection) => serviceCollection.AddServiceModelServices().AddServiceModelMetadata();

    /// <summary>
    /// Add default endpoint with <c>"/efatura"</c> value. Create binding configuration required by TR Government.
    /// </summary>
    /// <typeparam name="TServiceContract">Class that implements IEDocumentProxy interface.</typeparam>
    /// <typeparam name="TServiceImplemantation">IEDocumentProxy or Interface that inherit IEDocumentProxy.</typeparam>
    /// <param name="applicationBuilder">.NET IApplicationBuilder interface.</param>
    public static void UseEdocumentEndpoint<TServiceContract, TServiceImplemantation>(this IApplicationBuilder applicationBuilder)
        where TServiceContract : IEDocumentEndpoint
        where TServiceImplemantation : class
    {
        applicationBuilder.UseServiceModel(builder => _ = builder.AddService<TServiceImplemantation>().AddServiceEndpoint<TServiceImplemantation, TServiceContract>(GetHttpBinding(), "/efatura"));
        applicationBuilder.UseServiceModel(builder => _ = builder.AddService<TServiceImplemantation>().AddServiceEndpoint<TServiceImplemantation, TServiceContract>(GetHttpsBinding(), "/efatura"));
    }

    /// <summary>
    /// Add default endpoint with <paramref name="path"/> value. Create default binding configuration required by TR Government.
    /// </summary>
    /// <typeparam name="TServiceContract">Class that implements <c>IEDocumentProxy</c> interface.</typeparam>
    /// <typeparam name="TServiceImplemantation">IEDocumentProxy or Interface that inherit  <c>IEDocumentProxy</c>.</typeparam>
    /// <param name="applicationBuilder">.NET IApplicationBuilder interface.</param>
    /// <param name="path">Path that IEDocumentProxy will listen</param>
    public static void UseEdocumentEndpoint<TServiceContract, TServiceImplemantation>(this IApplicationBuilder applicationBuilder, string path)
        where TServiceContract : IEDocumentEndpoint
        where TServiceImplemantation : class => applicationBuilder.UseServiceModel(builder =>
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            _ = builder.AddService<TServiceImplemantation>().AddServiceEndpoint<TServiceImplemantation, TServiceContract>(GetHttpBinding(), path);
            _ = builder.AddService<TServiceImplemantation>().AddServiceEndpoint<TServiceImplemantation, TServiceContract>(GetHttpsBinding(), path);
        });

    private static CustomBinding GetHttpBinding()
    {
        var customBinding = new CustomBinding();
        var mtomMessageEncodingBindingElement = new MtomMessageEncodingBindingElement
        {
            MaxReadPoolSize = 64,
            MaxWritePoolSize = 16,
            MessageVersion = MessageVersion.Soap12,
            MaxBufferSize = 65536,
            WriteEncoding = Encoding.UTF8,
        };

        mtomMessageEncodingBindingElement.ReaderQuotas.MaxDepth = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxStringContentLength = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxArrayLength = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxBytesPerRead = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxNameTableCharCount = 2147483647;

        customBinding.Elements.Add(mtomMessageEncodingBindingElement);

        var httpTransportBindingElement = new HttpTransportBindingElement
        {
            ManualAddressing = false,
            MaxBufferPoolSize = 2147483647,
            MaxReceivedMessageSize = 2147483647,
            AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous,
            KeepAliveEnabled = true,
            MaxBufferSize = 2147483647,
            Realm = string.Empty,
        };
        customBinding.Elements.Add(httpTransportBindingElement);
        customBinding.SendTimeout = new TimeSpan(0, 3, 0);
        customBinding.OpenTimeout = new TimeSpan(0, 1, 0);
        customBinding.ReceiveTimeout = new TimeSpan(0, 3, 0);
        customBinding.CloseTimeout = new TimeSpan(0, 1, 0);

        return customBinding;
    }

    private static CustomBinding GetHttpsBinding()
    {
        var customBinding = new CustomBinding();
        var mtomMessageEncodingBindingElement = new MtomMessageEncodingBindingElement
        {
            MaxReadPoolSize = 64,
            MaxWritePoolSize = 16,
            MessageVersion = MessageVersion.Soap12,
            MaxBufferSize = 65536,
            WriteEncoding = Encoding.UTF8,
        };

        mtomMessageEncodingBindingElement.ReaderQuotas.MaxDepth = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxStringContentLength = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxArrayLength = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxBytesPerRead = 2147483647;
        mtomMessageEncodingBindingElement.ReaderQuotas.MaxNameTableCharCount = 2147483647;

        customBinding.Elements.Add(mtomMessageEncodingBindingElement);

        var httpsTransportBindingElement = new HttpsTransportBindingElement
        {
            ManualAddressing = false,
            MaxBufferPoolSize = 2147483647,
            MaxReceivedMessageSize = 2147483647,
            AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous,
            KeepAliveEnabled = true,
            MaxBufferSize = 2147483647,
            Realm = string.Empty,
        };
        customBinding.Elements.Add(httpsTransportBindingElement);
        customBinding.SendTimeout = new TimeSpan(0, 3, 0);
        customBinding.OpenTimeout = new TimeSpan(0, 1, 0);
        customBinding.ReceiveTimeout = new TimeSpan(0, 3, 0);
        customBinding.CloseTimeout = new TimeSpan(0, 1, 0);

        return customBinding;
    }
}
