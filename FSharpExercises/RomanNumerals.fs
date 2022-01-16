namespace FSharpKoans
open FSharpExercises.Core
open NUnit.Framework

module RomanNumerals =

    // From https://en.wikipedia.org/wiki/Roman_numerals
    // Roman numerals are essentially a decimal or "base ten" number system, but
    // instead of place value notation (in which place-keeping zeros enable a digit to represent
    // different powers of ten) the system uses a set of symbols with fixed values, including
    // "built in" powers of ten. Tally-like combinations of these fixed symbols correspond to
    // the (placed) digits of Arabic numerals. This structure allows for significant flexibility
    // in notation, and many variant forms are attested.

    // The values are:
    // Symbol	I	V	X	L	C	D	M
    // Value	1	5	10	50	100	500	1000

    // Symbol order matters. A smaller symbol preceding a larger ones means subtract the smaller
    // but it must be the immediately preceding value. Otherwise symbols must appear in deceding
    // order.

    [<Ignore("Not implemented");Test>]
    let ConvertToRomainNumeros() =

        let convertInt numeroString =
            __

        AssertEquality "X" (convertInt  10)
        AssertEquality "C" (convertInt 100)
        AssertEquality "XV" (convertInt 15)
        AssertEquality "CCXXVI" (convertInt 226)
        AssertEquality "MCCCLXXII" (convertInt 1372)
        AssertEquality "XIV" (convertInt 14)
        AssertEquality "CDXXXVII" (convertInt 437)

    [<Ignore("Not implemented");Test>]
    let ConvertFromRomainNumeros() =

        let convertNumero numeroString =
            __

        AssertEquality (Some 10) (convertNumero "X")
        AssertEquality (Some 100) (convertNumero "C")
        AssertEquality (Some 15) (convertNumero "XV")
        AssertEquality (Some 226) (convertNumero "CCXXVI")
        AssertEquality (Some 1372) (convertNumero "MCCCLXXII")
        AssertEquality (Some 14) (convertNumero "XIV")
        AssertEquality (Some 437) (convertNumero "CDXXXVII")
        AssertEquality None (convertNumero "VC")
        AssertEquality None (convertNumero "VIV")

