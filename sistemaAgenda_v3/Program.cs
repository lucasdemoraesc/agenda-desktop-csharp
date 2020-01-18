#region LICENSE

/*****************************************************************************
 *                                                                           *
 *	Agenda pessoal. Sistema para armazenar contatos de pessoas.              *
 *  Copyright(C) 2020  Lucas De Moraes Corrêa                                *
 *                                                                           *
 *  This program is free software: you can redistribute it and/or modify     *
 *	it under the terms of the GNU General Public License as published by     *
 *	the Free Software Foundation, either version 3 of the License, or        *
 *	(at your option) any later version.                                      *
 *                                                                           *
 *	This program is distributed in the hope that it will be useful,          *
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of           *
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the              *
 *	GNU General Public License for more details.                             *
 *                                                                           *
 *	You should have received a copy of the GNU General Public License        *
 *	along with this program.If not, see<https://www.gnu.org/licenses/>.      *
 *                                                                           *
 ****************************************************************************/

#endregion

using System;
using System.Windows.Forms;

namespace sistemaAgenda_v3
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
