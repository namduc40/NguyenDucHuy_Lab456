﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDucHuy_Lab456.Startup))]
namespace NguyenDucHuy_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
