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
    /// Test of RotationalStiffnessPerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalStiffnessPerLengthTestsBase : QuantityTestsBase
    {
        protected abstract double KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double KilopoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double PoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilonewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceFeetPerDegreesPerFeetTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double PoundForceFeetPerDegreesPerFeetTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(RotationalStiffnessPerLengthUnit unit)
        {
            return unit switch
            {
                RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter => (KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance),
                RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot => (KilopoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, KilopoundForceFeetPerDegreesPerFeetTolerance),
                RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter => (MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance),
                RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter => (NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance),
                RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot => (PoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, PoundForceFeetPerDegreesPerFeetTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter },
            new object[] { RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot },
            new object[] { RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter },
            new object[] { RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter },
            new object[] { RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength((double)0.0, RotationalStiffnessPerLengthUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RotationalStiffnessPerLength();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength(double.PositiveInfinity, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength(double.NegativeInfinity, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength(double.NaN, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalStiffnessPerLength(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new RotationalStiffnessPerLength(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (RotationalStiffnessPerLength) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void RotationalStiffnessPerLength_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter);

            QuantityInfo<RotationalStiffnessPerLengthUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RotationalStiffnessPerLength.Zero, quantityInfo.Zero);
            Assert.Equal("RotationalStiffnessPerLength", quantityInfo.Name);
            Assert.Equal(QuantityType.RotationalStiffnessPerLength, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<RotationalStiffnessPerLengthUnit>().Except(new[] {RotationalStiffnessPerLengthUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void NewtonMeterPerRadianPerMeterToRotationalStiffnessPerLengthUnits()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.KilopoundForceFeetPerDegreesPerFeet, KilopoundForceFeetPerDegreesPerFeetTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(PoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.PoundForceFeetPerDegreesPerFeet, PoundForceFeetPerDegreesPerFeetTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(1, quantity00.KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter, quantity00.Unit);

            var quantity01 = RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot);
            AssertEx.EqualTolerance(1, quantity01.KilopoundForceFeetPerDegreesPerFeet, KilopoundForceFeetPerDegreesPerFeetTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot, quantity01.Unit);

            var quantity02 = RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(1, quantity02.MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter, quantity02.Unit);

            var quantity03 = RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(1, quantity03.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, quantity03.Unit);

            var quantity04 = RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot);
            AssertEx.EqualTolerance(1, quantity04.PoundForceFeetPerDegreesPerFeet, PoundForceFeetPerDegreesPerFeetTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot, quantity04.Unit);

        }

        [Fact]
        public void FromNewtonMetersPerRadianPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonMetersPerRadianPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter), KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot), KilopoundForceFeetPerDegreesPerFeetTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter), MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter), NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(PoundForceFeetPerDegreesPerFeetInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot), PoundForceFeetPerDegreesPerFeetTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RotationalStiffnessPerLength(value: 1, unit: RotationalStiffnessPerLength.BaseUnit);
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
        public void ToUnit(RotationalStiffnessPerLengthUnit unit)
        {
            var inBaseUnits = RotationalStiffnessPerLength.From(1.0, RotationalStiffnessPerLength.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(RotationalStiffnessPerLengthUnit unit)
        {
            var quantity = RotationalStiffnessPerLength.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(RotationalStiffnessPerLengthUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = RotationalStiffnessPerLength.Units.FirstOrDefault(u => u != RotationalStiffnessPerLength.BaseUnit && u != RotationalStiffnessPerLengthUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == RotationalStiffnessPerLengthUnit.Undefined)
                fromUnit = RotationalStiffnessPerLength.BaseUnit;

            var quantity = RotationalStiffnessPerLength.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromKilonewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromKilopoundForceFeetPerDegreesPerFeet(newtonmeterperradianpermeter.KilopoundForceFeetPerDegreesPerFeet).NewtonMetersPerRadianPerMeter, KilopoundForceFeetPerDegreesPerFeetTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromMeganewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromPoundForceFeetPerDegreesPerFeet(newtonmeterperradianpermeter.PoundForceFeetPerDegreesPerFeet).NewtonMetersPerRadianPerMeter, PoundForceFeetPerDegreesPerFeetTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalStiffnessPerLength v = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(3)-v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(10)/5).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(10)/RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(5), NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalStiffnessPerLength oneNewtonMeterPerRadianPerMeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            RotationalStiffnessPerLength twoNewtonMetersPerRadianPerMeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(oneNewtonMeterPerRadianPerMeter < twoNewtonMetersPerRadianPerMeter);
            Assert.True(oneNewtonMeterPerRadianPerMeter <= twoNewtonMetersPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter > oneNewtonMeterPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter >= oneNewtonMeterPerRadianPerMeter);

            Assert.False(oneNewtonMeterPerRadianPerMeter > twoNewtonMetersPerRadianPerMeter);
            Assert.False(oneNewtonMeterPerRadianPerMeter >= twoNewtonMetersPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter < oneNewtonMeterPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter <= oneNewtonMeterPerRadianPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Equal(0, newtonmeterperradianpermeter.CompareTo(newtonmeterperradianpermeter));
            Assert.True(newtonmeterperradianpermeter.CompareTo(RotationalStiffnessPerLength.Zero) > 0);
            Assert.True(RotationalStiffnessPerLength.Zero.CompareTo(newtonmeterperradianpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonmeterperradianpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterperradianpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            var b = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

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
            var a = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            var b = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            object b = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.True(v.Equals(RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1), NewtonMetersPerRadianPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalStiffnessPerLength.Zero, NewtonMetersPerRadianPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalStiffnessPerLengthUnit.Undefined, RotationalStiffnessPerLength.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalStiffnessPerLengthUnit)).Cast<RotationalStiffnessPerLengthUnit>();
            foreach(var unit in units)
            {
                if (unit == RotationalStiffnessPerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalStiffnessPerLength.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kN·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter).ToString());
                Assert.Equal("1 kipf·ft/°/ft", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot).ToString());
                Assert.Equal("1 MN·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter).ToString());
                Assert.Equal("1 N·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString());
                Assert.Equal("1 lbf·ft/deg/ft", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot).ToString());
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

            Assert.Equal("1 kN·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter).ToString(swedishCulture));
            Assert.Equal("1 kipf·ft/°/ft", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot).ToString(swedishCulture));
            Assert.Equal("1 MN·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter).ToString(swedishCulture));
            Assert.Equal("1 N·m/rad/m", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString(swedishCulture));
            Assert.Equal("1 lbf·ft/deg/ft", new RotationalStiffnessPerLength(1, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s1"));
                Assert.Equal("0.12 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s2"));
                Assert.Equal("0.123 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s3"));
                Assert.Equal("0.1235 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s4"));
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
            Assert.Equal("0.1 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 N·m/rad/m", new RotationalStiffnessPerLength(0.123456, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(RotationalStiffnessPerLength)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RotationalStiffnessPerLengthUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(QuantityType.RotationalStiffnessPerLength, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(RotationalStiffnessPerLength.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(RotationalStiffnessPerLength.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1.0);
            Assert.Equal(new {RotationalStiffnessPerLength.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(value);
            Assert.Equal(RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(-value), -quantity);
        }
    }
}
