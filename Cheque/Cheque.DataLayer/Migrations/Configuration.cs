﻿using System.Data.Entity.Migrations;
using Cheque.DataLayer.Context;

namespace Cheque.DataLayer.Migrations
{
    /// <summary>
    /// </summary>
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        #region Ctor

        /// <summary>
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        #endregion

        #region Seed

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ApplicationDbContext context)
        {
        }

        #endregion
    }
}