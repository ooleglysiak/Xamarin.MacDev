﻿// 
// AppleTVOSSdk.cs
//  
// Authors: Michael Hutchinson <mhutch@xamarin.com>
//          Jeffrey Stedfast <jeff@xamarin.com>
//          Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright (c) 2011-2013, 2015 Xamarin Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;

namespace Xamarin.MacDev
{
	public class AppleTVOSSdk : AppleSdk
	{
		List<IPhoneSdkVersion> knownOSVersions = new List<IPhoneSdkVersion> {
			IPhoneSdkVersion.V9_0,
			IPhoneSdkVersion.V9_1,
			IPhoneSdkVersion.V9_2,
			IPhoneSdkVersion.V10_0,
		};

		protected override string SimulatorPlatformName {
			get {
				return "AppleTVSimulator";
			}
		}

		protected override string DevicePlatformName {
			get {
				return "AppleTVOS";
			}
		}

		protected override List<IPhoneSdkVersion> InitiallyKnownOSVersions {
			get {
				return knownOSVersions;
			}
		}

		public AppleTVOSSdk (string sdkRoot, string versionPlist)
		{
			DeveloperRoot = sdkRoot;
			VersionPlist = versionPlist;
			Init ();
		}
	}
}
