﻿// <copyright file="BasePageSingletonDerived.cs" company="Automate The Planet Ltd.">
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

using SingletonDesignPattern.Base;

namespace SingletonDesignPattern.Core;

public abstract class BasePageSingletonDerived<TS, TM> : ThreadSafeNestedContructorsBaseSingleton<TS>
    where TM : BasePageElementMap, new()
    where TS : BasePageSingletonDerived<TS, TM>
{
    public BasePageSingletonDerived()
    {
    }

    protected TM Map
    {
        get
        {
            return new TM();
        }
    }

    public virtual void Navigate(string url = "")
    {
        Driver.Browser.Navigate().GoToUrl(string.Concat(url));
    }
}

public abstract class BasePageSingletonDerived<TS, TM, TV> : BasePageSingletonDerived<TS, TM>
    where TM : BasePageElementMap, new()
    where TV : BasePageValidator<TM>, new()
    where TS : BasePageSingletonDerived<TS, TM, TV>
{
    public TV Validate()
    {
        return new TV();
    }
}