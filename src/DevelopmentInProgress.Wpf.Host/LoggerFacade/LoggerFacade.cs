﻿//-----------------------------------------------------------------------
// <copyright file="LoggerFacade.cs" company="Development In Progress Ltd">
//     Copyright © 2012. All rights reserved.
// </copyright>
// <author>Grant Colley</author>
//-----------------------------------------------------------------------

using Prism.Logging;
using Serilog;

namespace DevelopmentInProgress.Wpf.Host.LoggerFacade
{
    /// <summary>
    /// The logger facade implementing a log4net logger.
    /// </summary>
    public class LoggerFacade : ILoggerFacade
    {
        /// <summary>
        /// Instance if the log4net logger.
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the LoggerFacade class that implements the log4net logger.
        /// </summary>
        public LoggerFacade(ILogger logger)
        {
            this.logger = logger;

            logger.Information("*********************************************");
            logger.Information("*********************************************");
            logger.Information("Development In Progress - Wpf Host");
            logger.Information("Copyright © Development In Progress 2018");
            logger.Information("Start Application");
        }

        /// <summary>
        /// Writes a message to the log.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The message category.</param>
        /// <param name="priority">The log priority.</param>
        public void Log(string message, Category category, Priority priority)
        {
            switch (category)
            {
                case Category.Debug:
                    logger.Debug(message);
                    break;
                case Category.Warn:
                    logger.Warning(message);
                    break;
                case Category.Exception:
                    logger.Error(message);
                    break;
                case Category.Info:
                    logger.Information(message);
                    break;
            }
        }
    }
}