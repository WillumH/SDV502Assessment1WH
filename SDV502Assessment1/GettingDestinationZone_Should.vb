Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports FastwayCourier

<TestClass()> Public Class GettingDestinationZone_Should

    <TestMethod()> Public Sub returnBlue_IfDestinationIsHavelock()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Havelock"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnBlue_IfDestinationIsRiwaka()

        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Riwaka"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnBlue_IfDestinationIsSeddon()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Seddon"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnBlue_IfDestinationIsTakaka()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Takaka"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnBlue_IfDestinationIsWaihopaiValley()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Waihopai Valley"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnBlue_IfDestinationIsWard()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Ward"
        Dim Expected As String = "Blue"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub returnLime_IfDestinationIsMurchison()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Murchison"
        Dim Expected As String = "Lime"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnLime_IfDestinationIsNelsonLakesNationalPark()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Nelson Lakes National Park"
        Dim Expected As String = "Lime"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub returnOrange_IfDestinationIsHanmerSprings()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Hanmer Springs"
        Dim Expected As String = "Orange"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnOrange_IfDestinationIsKaikoura()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Kaikoura"
        Dim Expected As String = "Orange"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnOrange_IfDestinationIsReefton()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Reefton"
        Dim Expected As String = "Orange"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub






    <TestMethod()> Public Sub returnPink_IfDestinationIsAtawhai()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Atawhai"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsBlenheim()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Blenheim"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsBrightwater()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Brightwater"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsHope()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Hope"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsMaitai()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Maitai"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsMapua()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Mapua"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsMotueka()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Motueka"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsNelson()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Nelson"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsPicton()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Picton"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsRenwick()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Renwick"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

    <TestMethod()> Public Sub returnPink_IfDestinationIsWakefield()
        'Arrange
        Dim Zone As ParcelQuoteFromNelson = New ParcelQuoteFromNelson
        Dim Destination As String = "Wakefield"
        Dim Expected As String = "Pink"
        Dim Actual As String
        'Act
        Actual = Zone.GetDestinationZone(Destination)
        'Assert
        Assert.AreEqual(Expected, Actual)
    End Sub

End Class