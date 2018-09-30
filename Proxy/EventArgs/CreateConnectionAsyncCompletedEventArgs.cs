//
//  Author:
//       Benton Stark <benton.stark@gmail.com>
//
//  Copyright (c) 2016 Benton Stark
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace ProxyLib.Proxy.EventArgs
{
    /// <summary>
    /// Event arguments class for the EncryptAsyncCompleted event.
    /// </summary>
    public class CreateConnectionAsyncCompletedEventArgs : AsyncCompletedEventArgs
    {
        private TcpClient _proxyConnection;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="error">Exception information generated by the event.</param>
        /// <param name="cancelled">Cancelled event flag.  This flag is set to true if the event was cancelled.</param>
        /// <param name="proxyConnection">Proxy Connection.  The initialized and open TcpClient proxy connection.</param>
        public CreateConnectionAsyncCompletedEventArgs(Exception error, bool cancelled, TcpClient proxyConnection)
            : base(error, cancelled, null)
        {
            _proxyConnection = proxyConnection;
        }

        /// <summary>
        /// The proxy connection.
        /// </summary>
        public TcpClient ProxyConnection
        {
            get { return _proxyConnection; }
        }
    }

} 