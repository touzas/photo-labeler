﻿// Copyright (c) Juanjo Montiel and contributors. All Rights Reserved. Licensed under the GNU General Public License, Version 2.0. See LICENSE in the project root for license information.

using System.Threading.Tasks;
using PhotoLabeler.ServiceLibrary.Implementations;

namespace PhotoLabeler.Console
{
	class Program
	{
		static async Task Main()
		{
			var service = new PhotoInfoService();
			var photo = await service.GetPhotoFromFileAsync(@"c:\users\jmontiel\google drive\fotos\2. Amberso DNI Juanjo.JPG");
			System.Console.ReadLine();
		}


	}
}
