/*
 * Copyright 2021 Automate The Planet Ltd.
 * Author: Anton Angelov
 * Licensed under the Apache License, Version 2.0 (the "License");
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package decorator.services;

import decorator.enums.Country;

public class VatTaxCalculationService {
    double taxValue;
    public double calculate(double price, Country country) {
        switch(country) {
            case BULGARIA:
            case UNITED_KINGDOM:
            case GERMANY:
            case AUSTRIA:
            case FRANCE:
                taxValue = calculateVATInternal(price, 20);
                break;
            default:
                taxValue = 0;
                break;
        }

        return taxValue;
    }

    private static double calculateVATInternal(double price, double percent) {
        var taxValue = price*percent/100;
        return taxValue;
    }
}
