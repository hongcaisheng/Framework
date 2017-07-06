﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib.API.Debugger;

namespace CatLib.Debugger.LogHandler
{
    /// <summary>
    /// 日志处理器
    /// </summary>
    public interface ILogHandler
    {
        /// <summary>
        /// 日志处理器
        /// </summary>
        /// <param name="level">日志等级</param>
        /// <param name="message">日志内容</param>
        void Handler(LogLevels level , string message);
    }
}
