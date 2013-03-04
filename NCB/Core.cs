/***************************************************************************
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) version 3.                                           *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.         *
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;

namespace NCB
{
    class Core
    {
        public static System.Threading.Thread ServerThread = null;

        public static void WriteLog(string log)
        { 
            System.Console.WriteLine(DateTime.Now.ToString() + " SYSLOG: " + log);
            return;
        }

        public static void handleException(Exception what)
        {
            WriteLog("Exception: " + what.ToString());
        }

        public static void LoadConf()
        { 
            
        }

        public static void CreateServer()
        {
            try
            {
                Server server = new Server();
                while (server.Running)
                {
                    server.Wait();
                    System.Threading.Thread.Sleep(100);
                }
            } catch (Exception fail)
            {
                Core.handleException(fail);
            }
        }

        public static bool Load()
        {
            LoadConf();
            return true;
        }
    }
}
