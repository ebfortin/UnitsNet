//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of WarpingMomentOfInertia.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class WarpingMomentOfInertiaTestsBase : QuantityTestsBase
    {
        protected abstract double CentimetersToTheSixthInOneMeterToTheSixth { get; }
        protected abstract double DecimetersToTheSixthInOneMeterToTheSixth { get; }
        protected abstract double FeetToTheSixthInOneMeterToTheSixth { get; }
        protected abstract double InchesToTheSixthInOneMeterToTheSixth { get; }
        protected abstract double MetersToTheSixthInOneMeterToTheSixth { get; }
        protected abstract double MillimetersToTheSixthInOneMeterToTheSixth { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimetersToTheSixthTolerance { get { return 1e-5; } }
        protected virtual double DecimetersToTheSixthTolerance { get { return 1e-5; } }
        protected virtual double FeetToTheSixthTolerance { get { return 1e-5; } }
        protected virtual double InchesToTheSixthTolerance { get { return 1e-5; } }
        protected virtual double MetersToTheSixthTolerance { get { return 1e-5; } }
        protected virtual double MillimetersToTheSixthTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(WarpingMomentOfInertiaUnit unit)
        {
            return unit switch
            {
                WarpingMomentOfInertiaUnit.CentimeterToTheSixth => (CentimetersToTheSixthInOneMeterToTheSixth, CentimetersToTheSixthTolerance),
                WarpingMomentOfInertiaUnit.DecimeterToTheSixth => (DecimetersToTheSixthInOneMeterToTheSixth, DecimetersToTheSixthTolerance),
                WarpingMomentOfInertiaUnit.FootToTheSixth => (FeetToTheSixthInOneMeterToTheSixth, FeetToTheSixthTolerance),
                WarpingMomentOfInertiaUnit.InchToTheSixth => (InchesToTheSixthInOneMeterToTheSixth, InchesToTheSixthTolerance),
                WarpingMomentOfInertiaUnit.MeterToTheSixth => (MetersToTheSixthInOneMeterToTheSixth, MetersToTheSixthTolerance),
                WarpingMomentOfInertiaUnit.MillimeterToTheSixth => (MillimetersToTheSixthInOneMeterToTheSixth, MillimetersToTheSixthTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { WarpingMomentOfInertiaUnit.CentimeterToTheSixth },
            new object[] { WarpingMomentOfInertiaUnit.DecimeterToTheSixth },
            new object[] { WarpingMomentOfInertiaUnit.FootToTheSixth },
            new object[] { WarpingMomentOfInertiaUnit.InchToTheSixth },
            new object[] { WarpingMomentOfInertiaUnit.MeterToTheSixth },
            new object[] { WarpingMomentOfInertiaUnit.MillimeterToTheSixth },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new WarpingMomentOfInertia((double)0.0, WarpingMomentOfInertiaUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new WarpingMomentOfInertia();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(WarpingMomentOfInertiaUnit.MeterToTheSixth, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new WarpingMomentOfInertia(double.PositiveInfinity, WarpingMomentOfInertiaUnit.MeterToTheSixth));
            Assert.Throws<ArgumentException>(() => new WarpingMomentOfInertia(double.NegativeInfinity, WarpingMomentOfInertiaUnit.MeterToTheSixth));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new WarpingMomentOfInertia(double.NaN, WarpingMomentOfInertiaUnit.MeterToTheSixth));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new WarpingMomentOfInertia(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new WarpingMomentOfInertia(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (WarpingMomentOfInertia) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void WarpingMomentOfInertia_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.MeterToTheSixth);

            QuantityInfo<WarpingMomentOfInertiaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(WarpingMomentOfInertia.Zero, quantityInfo.Zero);
            Assert.Equal("WarpingMomentOfInertia", quantityInfo.Name);
            Assert.Equal(QuantityType.WarpingMomentOfInertia, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<WarpingMomentOfInertiaUnit>().Except(new[] {WarpingMomentOfInertiaUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void MeterToTheSixthToWarpingMomentOfInertiaUnits()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            AssertEx.EqualTolerance(CentimetersToTheSixthInOneMeterToTheSixth, metertothesixth.CentimetersToTheSixth, CentimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheSixthInOneMeterToTheSixth, metertothesixth.DecimetersToTheSixth, DecimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(FeetToTheSixthInOneMeterToTheSixth, metertothesixth.FeetToTheSixth, FeetToTheSixthTolerance);
            AssertEx.EqualTolerance(InchesToTheSixthInOneMeterToTheSixth, metertothesixth.InchesToTheSixth, InchesToTheSixthTolerance);
            AssertEx.EqualTolerance(MetersToTheSixthInOneMeterToTheSixth, metertothesixth.MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheSixthInOneMeterToTheSixth, metertothesixth.MillimetersToTheSixth, MillimetersToTheSixthTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.CentimeterToTheSixth);
            AssertEx.EqualTolerance(1, quantity00.CentimetersToTheSixth, CentimetersToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.CentimeterToTheSixth, quantity00.Unit);

            var quantity01 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.DecimeterToTheSixth);
            AssertEx.EqualTolerance(1, quantity01.DecimetersToTheSixth, DecimetersToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.DecimeterToTheSixth, quantity01.Unit);

            var quantity02 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.FootToTheSixth);
            AssertEx.EqualTolerance(1, quantity02.FeetToTheSixth, FeetToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.FootToTheSixth, quantity02.Unit);

            var quantity03 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.InchToTheSixth);
            AssertEx.EqualTolerance(1, quantity03.InchesToTheSixth, InchesToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.InchToTheSixth, quantity03.Unit);

            var quantity04 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.MeterToTheSixth);
            AssertEx.EqualTolerance(1, quantity04.MetersToTheSixth, MetersToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.MeterToTheSixth, quantity04.Unit);

            var quantity05 = WarpingMomentOfInertia.From(1, WarpingMomentOfInertiaUnit.MillimeterToTheSixth);
            AssertEx.EqualTolerance(1, quantity05.MillimetersToTheSixth, MillimetersToTheSixthTolerance);
            Assert.Equal(WarpingMomentOfInertiaUnit.MillimeterToTheSixth, quantity05.Unit);

        }

        [Fact]
        public void FromMetersToTheSixth_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => WarpingMomentOfInertia.FromMetersToTheSixth(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => WarpingMomentOfInertia.FromMetersToTheSixth(double.NegativeInfinity));
        }

        [Fact]
        public void FromMetersToTheSixth_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => WarpingMomentOfInertia.FromMetersToTheSixth(double.NaN));
        }

        [Fact]
        public void As()
        {
            var metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            AssertEx.EqualTolerance(CentimetersToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.CentimeterToTheSixth), CentimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.DecimeterToTheSixth), DecimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(FeetToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.FootToTheSixth), FeetToTheSixthTolerance);
            AssertEx.EqualTolerance(InchesToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.InchToTheSixth), InchesToTheSixthTolerance);
            AssertEx.EqualTolerance(MetersToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.MeterToTheSixth), MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheSixthInOneMeterToTheSixth, metertothesixth.As(WarpingMomentOfInertiaUnit.MillimeterToTheSixth), MillimetersToTheSixthTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new WarpingMomentOfInertia(value: 1, unit: WarpingMomentOfInertia.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(WarpingMomentOfInertiaUnit unit)
        {
            var inBaseUnits = WarpingMomentOfInertia.From(1.0, WarpingMomentOfInertia.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(WarpingMomentOfInertiaUnit unit)
        {
            var quantity = WarpingMomentOfInertia.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(WarpingMomentOfInertiaUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = WarpingMomentOfInertia.Units.FirstOrDefault(u => u != WarpingMomentOfInertia.BaseUnit && u != WarpingMomentOfInertiaUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == WarpingMomentOfInertiaUnit.Undefined)
                fromUnit = WarpingMomentOfInertia.BaseUnit;

            var quantity = WarpingMomentOfInertia.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromCentimetersToTheSixth(metertothesixth.CentimetersToTheSixth).MetersToTheSixth, CentimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromDecimetersToTheSixth(metertothesixth.DecimetersToTheSixth).MetersToTheSixth, DecimetersToTheSixthTolerance);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromFeetToTheSixth(metertothesixth.FeetToTheSixth).MetersToTheSixth, FeetToTheSixthTolerance);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromInchesToTheSixth(metertothesixth.InchesToTheSixth).MetersToTheSixth, InchesToTheSixthTolerance);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromMetersToTheSixth(metertothesixth.MetersToTheSixth).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(1, WarpingMomentOfInertia.FromMillimetersToTheSixth(metertothesixth.MillimetersToTheSixth).MetersToTheSixth, MillimetersToTheSixthTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            WarpingMomentOfInertia v = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            AssertEx.EqualTolerance(-1, -v.MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(2, (WarpingMomentOfInertia.FromMetersToTheSixth(3)-v).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(2, (v + v).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(10, (v*10).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(10, (10*v).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(2, (WarpingMomentOfInertia.FromMetersToTheSixth(10)/5).MetersToTheSixth, MetersToTheSixthTolerance);
            AssertEx.EqualTolerance(2, WarpingMomentOfInertia.FromMetersToTheSixth(10)/WarpingMomentOfInertia.FromMetersToTheSixth(5), MetersToTheSixthTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            WarpingMomentOfInertia oneMeterToTheSixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            WarpingMomentOfInertia twoMetersToTheSixth = WarpingMomentOfInertia.FromMetersToTheSixth(2);

            Assert.True(oneMeterToTheSixth < twoMetersToTheSixth);
            Assert.True(oneMeterToTheSixth <= twoMetersToTheSixth);
            Assert.True(twoMetersToTheSixth > oneMeterToTheSixth);
            Assert.True(twoMetersToTheSixth >= oneMeterToTheSixth);

            Assert.False(oneMeterToTheSixth > twoMetersToTheSixth);
            Assert.False(oneMeterToTheSixth >= twoMetersToTheSixth);
            Assert.False(twoMetersToTheSixth < oneMeterToTheSixth);
            Assert.False(twoMetersToTheSixth <= oneMeterToTheSixth);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.Equal(0, metertothesixth.CompareTo(metertothesixth));
            Assert.True(metertothesixth.CompareTo(WarpingMomentOfInertia.Zero) > 0);
            Assert.True(WarpingMomentOfInertia.Zero.CompareTo(metertothesixth) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.Throws<ArgumentException>(() => metertothesixth.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.Throws<ArgumentNullException>(() => metertothesixth.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            var b = WarpingMomentOfInertia.FromMetersToTheSixth(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            var b = WarpingMomentOfInertia.FromMetersToTheSixth(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            object b = WarpingMomentOfInertia.FromMetersToTheSixth(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.True(v.Equals(WarpingMomentOfInertia.FromMetersToTheSixth(1), MetersToTheSixthTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(WarpingMomentOfInertia.Zero, MetersToTheSixthTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(WarpingMomentOfInertia.FromMetersToTheSixth(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.False(metertothesixth.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            WarpingMomentOfInertia metertothesixth = WarpingMomentOfInertia.FromMetersToTheSixth(1);
            Assert.False(metertothesixth.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(WarpingMomentOfInertiaUnit.Undefined, WarpingMomentOfInertia.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(WarpingMomentOfInertiaUnit)).Cast<WarpingMomentOfInertiaUnit>();
            foreach(var unit in units)
            {
                if (unit == WarpingMomentOfInertiaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(WarpingMomentOfInertia.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.CentimeterToTheSixth).ToString());
                Assert.Equal("1 dm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.DecimeterToTheSixth).ToString());
                Assert.Equal("1 ft⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.FootToTheSixth).ToString());
                Assert.Equal("1 in⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.InchToTheSixth).ToString());
                Assert.Equal("1 m⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString());
                Assert.Equal("1 mm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.MillimeterToTheSixth).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.CentimeterToTheSixth).ToString(swedishCulture));
            Assert.Equal("1 dm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.DecimeterToTheSixth).ToString(swedishCulture));
            Assert.Equal("1 ft⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.FootToTheSixth).ToString(swedishCulture));
            Assert.Equal("1 in⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.InchToTheSixth).ToString(swedishCulture));
            Assert.Equal("1 m⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString(swedishCulture));
            Assert.Equal("1 mm⁶", new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.MillimeterToTheSixth).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s1"));
                Assert.Equal("0.12 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s2"));
                Assert.Equal("0.123 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s3"));
                Assert.Equal("0.1235 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s1", culture));
            Assert.Equal("0.12 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s2", culture));
            Assert.Equal("0.123 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s3", culture));
            Assert.Equal("0.1235 m⁶", new WarpingMomentOfInertia(0.123456, WarpingMomentOfInertiaUnit.MeterToTheSixth).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(WarpingMomentOfInertia)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(WarpingMomentOfInertiaUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(QuantityType.WarpingMomentOfInertia, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(WarpingMomentOfInertia.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(WarpingMomentOfInertia.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(1.0);
            Assert.Equal(new {WarpingMomentOfInertia.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = WarpingMomentOfInertia.FromMetersToTheSixth(value);
            Assert.Equal(WarpingMomentOfInertia.FromMetersToTheSixth(-value), -quantity);
        }
    }
}
