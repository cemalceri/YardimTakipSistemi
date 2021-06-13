using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<DosyaManager>().As<IDosyaService>();
            builder.RegisterType<EfDosyaDal>().As<IDosyaDal>();

            builder.RegisterType<IlceManager>().As<IIlceService>();
            builder.RegisterType<EfIlceDal>().As<IIlceDal>();

            builder.RegisterType<NesneDegerManager>().As<INesneDegerService>();
            builder.RegisterType<EfNesneDegerDal>().As<INesneDegerDal>();

            builder.RegisterType<NesneTipManager>().As<INesneTipService>();
            builder.RegisterType<EfNesneTipDal>().As<INesneTipDal>();

            builder.RegisterType<SehirManager>().As<ISehirService>();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>();

            builder.RegisterType<VatandasManager>().As<IVatandasService>();
            builder.RegisterType<EfVatandasDal>().As<IVatandasDal>();

            builder.RegisterType<YardimManager>().As<IYardimService>();
            builder.RegisterType<EfYardimDal>().As<IYardimDal>();

            builder.RegisterType<YardimSepetiManager>().As<IYardimSepetiService>();
            builder.RegisterType<EfYardimSepetiDal>().As<IYardimSepetiDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
