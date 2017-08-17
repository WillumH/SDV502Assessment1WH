Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports FastwayCourier

<TestClass()> Public Class CalculatingQuote_Should


    <TestMethod()> Public Sub Return4Point15And0_IfWeightIs12Point5AndZoneIsPink()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (12.5)
        Dim Zone As String = ("Pink")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return4Point15And0_IfWeightIs0Point01AndZoneIsPink()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (0.01)
        Dim Zone As String = ("Pink")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return4Point15And0_IfWeightIs25AndZoneIsPink()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (25)
        Dim Zone As String = ("Pink")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIsMinus1AndZoneIsPink()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (-1)
        Dim Zone As String = ("Pink")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIs26AndZoneIsPink()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (26)
        Dim Zone As String = ("Pink")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub Return6Point95And0_IfWeightIs12Point5AndZoneIsBlue()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (12.5)
        Dim Zone As String = ("Blue")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub
    
    <TestMethod()> Public Sub Return6Point95And0_IfWeightIs0Point01AndZoneIsBlue()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (0.01)
        Dim Zone As String = ("Blue")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return6Point95And0_IfWeightIs25AndZoneIsBlue()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (25)
        Dim Zone As String = ("Blue")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIsMinus1AndZoneIsBlue()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (-1)
        Dim Zone As String = ("Blue")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIs26AndZoneIsBlue()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (26)
        Dim Zone As String = ("Blue")
        Dim Expected = 4.15 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub Return8Point70And0_IfWeightIs12Point5AndZoneIsLime()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (12.5)
        Dim Zone As String = ("Lime")
        Dim Expected = 8.7 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return8Point70And0_IfWeightIs0Point01AndZoneIsLime()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (0.01)
        Dim Zone As String = ("Lime")
        Dim Expected = 8.7 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return14Point90And1_IfWeightIs25AndZoneIsLime()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (25)
        Dim Zone As String = ("Lime")
        Dim Expected = 14.9 And 1
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIsMinus1AndZoneIsLime()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (-1)
        Dim Zone As String = ("Lime")
        Dim Expected = 8.7 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIs26AndZoneIsLime()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (26)
        Dim Zone As String = ("Lime")
        Dim Expected = 14.9 And 1
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub Return12Point95And0_IfWeightIs12Point5AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (12.5)
        Dim Zone As String = ("Orange")
        Dim Expected = 12.95 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return12Point95And0_IfWeightIs0Point01AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (0.01)
        Dim Zone As String = ("Orange")
        Dim Expected = 12.95 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return19Point15And1_IfWeightIs16AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (16)
        Dim Zone As String = ("Orange")
        Dim Expected = 19.15 And 1
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub Return25Point35And2_IfWeightIs25AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (25)
        Dim Zone As String = ("Orange")
        Dim Expected = 25.35 And 2
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIsMinus1AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (-1)
        Dim Zone As String = ("Orange")
        Dim Expected = 12.95 And 0
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod, ExpectedException(GetType(System.ArgumentOutOfRangeException))> Public Sub ReturnThrowException_IfWeightIs26AndZoneIsOrange()
        'Arrange
        Dim Shipping As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Quote As ParcelQuoteResult = New ParcelQuoteResult
        Dim Weight As Decimal = (26)
        Dim Zone As String = ("Orange")
        Dim Expected = 25.35 And 2
        Dim Actual
        'Act
        Shipping.CalculateQuote(Weight, Zone)
        Actual = Quote.Price And Quote.ExcessTickets
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

End Class