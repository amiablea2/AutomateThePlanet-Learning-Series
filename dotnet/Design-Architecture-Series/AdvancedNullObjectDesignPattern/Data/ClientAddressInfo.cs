﻿// <copyright file="ClientAddressInfo.cs" company="Automate The Planet Ltd.">
// Copyright 2022 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>

namespace AdvancedNullObjectDesignPattern.Data;

public class ClientAddressInfo
{
    public string FullName { get; set; }

    public string Country { get; set; }

    public string Address1 { get; set; }

    public string City { get; set; }

    public string Phone { get; set; }

    public string Zip { get; set; }

    public string Email { get; set; }

    public string State { get; set; }
}