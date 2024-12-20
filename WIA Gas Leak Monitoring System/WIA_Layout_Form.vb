Public Class WIA_Layout_Form

    Public LocatioName As String
    Public Nearby_name As String
    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        ShowAllSensors()
    End Sub

    Private Sub btnS01_Click(sender As Object, e As EventArgs) Handles btnS01.Click, btnSelas01.Click
        LocatioName = "Selas 01"
        Nearby_name = "near (Line 21 and Line 22)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D00"
        DM_Reading2 = "D01"
        DM_Reading3 = "D02"

        Alarm_Reading1 = "C50.00"
        Alarm_Reading2 = "C50.01"
        Alarm_Reading3 = "C50.02"


        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()

    End Sub

    Private Sub btnS02_Click(sender As Object, e As EventArgs) Handles btnS02.Click, btnSelas02.Click
        LocatioName = "Selas 02"
        Nearby_name = "near (Line 23 and Line 24)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D03"
        DM_Reading2 = "D04"
        DM_Reading3 = "D05"

        Alarm_Reading1 = "C50.03"
        Alarm_Reading2 = "C50.04"
        Alarm_Reading3 = "C50.05"


        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS03_Click(sender As Object, e As EventArgs) Handles btnS03.Click, btnSelas03.Click
        LocatioName = "Selas 03"
        Nearby_name = "near (Line 25 and Line 26)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D06"
        DM_Reading2 = "D07"
        DM_Reading3 = "D08"


        Alarm_Reading1 = "C50.06"
        Alarm_Reading2 = "C50.07"
        Alarm_Reading3 = "C50.08"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS04_Click(sender As Object, e As EventArgs) Handles btnS04.Click, btnSelas04.Click
        LocatioName = "Selas 04"
        Nearby_name = "near (Line 27)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D9"
        DM_Reading2 = "D10"
        DM_Reading3 = "D12"


        Alarm_Reading1 = "C50.09"
        Alarm_Reading2 = "C50.10"
        Alarm_Reading3 = "C50.11"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS05_Click(sender As Object, e As EventArgs) Handles btnS05.Click, btnSelas05.Click
        LocatioName = "Selas 05"
        Nearby_name = "near (Line 29)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D12"
        DM_Reading2 = "D13"
        DM_Reading3 = "D14"

        Alarm_Reading1 = "C50.12"
        Alarm_Reading2 = "C50.13"
        Alarm_Reading3 = "C50.14"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS06_Click(sender As Object, e As EventArgs) Handles btnS06.Click, btnSelas06.Click
        LocatioName = "Selas 06"
        Nearby_name = "near (Line 30 and Line 31)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D15"
        DM_Reading2 = "D16"
        DM_Reading3 = "D17"

        Alarm_Reading1 = "C50.15"
        Alarm_Reading2 = "C51.00"
        Alarm_Reading3 = "C51.01"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS07_Click(sender As Object, e As EventArgs) Handles btnS07.Click, btnSelas07.Click
        LocatioName = "Selas 07"
        Nearby_name = "near (Line 33)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D18"
        DM_Reading2 = "D19"
        DM_Reading3 = "D20"

        Alarm_Reading1 = "C51.02"
        Alarm_Reading2 = "C51.03"
        Alarm_Reading3 = "C51.04"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS08_Click(sender As Object, e As EventArgs) Handles btnS08.Click, btnSelas08.Click
        LocatioName = "Selas 08"
        Nearby_name = "near (Line 35 and Line 36)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D21"
        DM_Reading2 = "D22"
        DM_Reading3 = "D23"

        Alarm_Reading1 = "C51.05"
        Alarm_Reading2 = "C51.06"
        Alarm_Reading3 = "C51.07"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS09_Click(sender As Object, e As EventArgs) Handles btnS09.Click, btnSelas09.Click
        LocatioName = "Selas 09"
        Nearby_name = "near (Line 37 and Line 38)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D24"
        DM_Reading2 = "D25"
        DM_Reading3 = "D26"

        Alarm_Reading1 = "C51.08"
        Alarm_Reading2 = "C51.09"
        Alarm_Reading3 = "C51.10"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS10_Click(sender As Object, e As EventArgs) Handles btnS10.Click, btnSelas10.Click
        LocatioName = "Selas 10"
        Nearby_name = "near (Line 39)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D27"
        DM_Reading2 = "D28"
        DM_Reading3 = "D29"

        Alarm_Reading1 = "C51.11"
        Alarm_Reading2 = "C51.12"
        Alarm_Reading3 = "C51.13"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS11_Click(sender As Object, e As EventArgs) Handles btnS11.Click, btnSelas11.Click
        LocatioName = "Selas 11"
        Nearby_name = "near (Line 40 and Line 42)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D30"
        DM_Reading2 = "D31"
        DM_Reading3 = "D32"

        Alarm_Reading1 = "C51.14"
        Alarm_Reading2 = "C51.15"
        Alarm_Reading3 = "C52.00"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS12_Click(sender As Object, e As EventArgs) Handles btnS12.Click, btnSelas12.Click
        LocatioName = "Selas 12"
        Nearby_name = "near (Line 45 and Line 46)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D33"
        DM_Reading2 = "D34"
        DM_Reading3 = "D35"

        Alarm_Reading1 = "C52.01"
        Alarm_Reading2 = "C52.02"
        Alarm_Reading3 = "C52.03"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnS13_Click(sender As Object, e As EventArgs) Handles btnS13.Click, btnSelas13.Click
        LocatioName = "Selas 13"
        Nearby_name = "near (Line 43)"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        DM_Reading1 = "D36"
        DM_Reading2 = "D37"
        DM_Reading3 = "D38"

        Alarm_Reading1 = "C52.04"
        Alarm_Reading2 = "C52.05"
        Alarm_Reading3 = "C52.06"

        ThreeVal_Read = True

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT01_Click(sender As Object, e As EventArgs) Handles btnT01.Click, btnTrench01.Click
        LocatioName = "Warehouse Trench"
        Nearby_name = "near loading dock roll-up door"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D39"
        Alarm_Reading2 = "C52.07"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT02_Click(sender As Object, e As EventArgs) Handles btnT02.Click, btnTrench02.Click
        LocatioName = "Warehouse Trench"
        Nearby_name = "at SBU Warehouse"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D40"
        Alarm_Reading2 = "C52.08"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT03_Click(sender As Object, e As EventArgs) Handles btnT03.Click, btnTrench03.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "near Warehouse Table"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D41"
        Alarm_Reading2 = "C52.09"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT04_Click(sender As Object, e As EventArgs) Handles btnT04.Click, btnTrench04.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "at TRTE"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D42"
        Alarm_Reading2 = "C52.10"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT05_Click(sender As Object, e As EventArgs) Handles btnT05.Click, btnTrench05.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "at TRTE Assy Mach Line 75"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D43"
        Alarm_Reading2 = "C52.11"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT06_Click(sender As Object, e As EventArgs) Handles btnT06.Click, btnTrench06.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "near TRTE MH Table"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D44"
        Alarm_Reading2 = "C52.12"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT07_Click(sender As Object, e As EventArgs) Handles btnT07.Click, btnTrench07.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "walkway between TRTE and NANO"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D45"
        Alarm_Reading2 = "C52.13"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT08_Click(sender As Object, e As EventArgs) Handles btnT08.Click, btnTrench08.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "at NANO MM Corn Cobs"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D46"
        Alarm_Reading2 = "C52.14"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT09_Click(sender As Object, e As EventArgs) Handles btnT09.Click, btnTrench09.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "at NANO Printer Line 50"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D47"
        Alarm_Reading2 = "C52.15"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT10_Click(sender As Object, e As EventArgs) Handles btnT10.Click, btnTrench10.Click
        LocatioName = "PICO to Square Nano Trench"
        Nearby_name = "at NANO Multimag"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D48"
        Alarm_Reading2 = "C53.00"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT11_Click(sender As Object, e As EventArgs) Handles btnT11.Click, btnTrench11.Click
        LocatioName = "PICO Trench"
        Nearby_name = "at Warehouse Rack"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D49"
        Alarm_Reading2 = "C53.01"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT12_Click(sender As Object, e As EventArgs) Handles btnT12.Click, btnTrench12.Click
        LocatioName = "PICO Trench"
        Nearby_name = "at SMF Pick and Place"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D50"
        Alarm_Reading2 = "C53.02"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT13_Click(sender As Object, e As EventArgs) Handles btnT13.Click, btnTrench13.Click
        LocatioName = "PICO Trench"
        Nearby_name = "at PICO MVD Semi Auto Premelt"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D51"
        Alarm_Reading2 = "C53.03"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT14_Click(sender As Object, e As EventArgs) Handles btnT14.Click, btnTrench14.Click
        LocatioName = "PICO Trench"
        Nearby_name = "Between SPC Barrier Line"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D52"
        Alarm_Reading2 = "C53.04"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT15_Click(sender As Object, e As EventArgs) Handles btnT15.Click, btnTrench15.Click
        LocatioName = "PICO Trench"
        Nearby_name = "near PICO Maintenance table"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D53"
        Alarm_Reading2 = "C53.05"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT16_Click(sender As Object, e As EventArgs) Handles btnT16.Click, btnTrench16.Click
        LocatioName = "PICO Trench"
        Nearby_name = "Between Auto MVD and Barrier Line"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D54"
        Alarm_Reading2 = "C53.06"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT17_Click(sender As Object, e As EventArgs) Handles btnT17.Click, btnTrench17.Click
        LocatioName = "PICO Trench"
        Nearby_name = "Between Line 6 and Diagonal"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D55"
        Alarm_Reading2 = "C53.07"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT18_Click(sender As Object, e As EventArgs) Handles btnT18.Click, btnTrench18.Click
        LocatioName = "PICO Trench"
        Nearby_name = "at PICO MM 04"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D56"
        Alarm_Reading2 = "C53.08"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT19_Click(sender As Object, e As EventArgs) Handles btnT19.Click, btnTrench19.Click
        LocatioName = "PICO Trench"
        Nearby_name = "Between MM3 and MM4"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D57"
        Alarm_Reading2 = "C53.09"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnT20_Click(sender As Object, e As EventArgs) Handles btnT20.Click, btnTrench20.Click
        LocatioName = "PICO Trench"
        Nearby_name = "Between MM1 and MM2"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D58"
        Alarm_Reading2 = "C53.10"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnGM1_Click(sender As Object, e As EventArgs) Handles btnGM1.Click, btnGasMixing1.Click
        LocatioName = "Gas Mixing"
        Nearby_name = "Gas Mixing 1"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D59"
        Alarm_Reading2 = "C53.11"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub

    Private Sub btnGM4_Click(sender As Object, e As EventArgs) Handles btnGM4.Click, btnGasMixing4.Click
        LocatioName = "Gas Mixing"
        Nearby_name = "Gas Mixing 4"

        ShowSenVal_Form.GroupBoxTitle.Text = LocatioName
        ShowSenVal_Form.lblnear.Text = Nearby_name

        ShowSenVal_Form.lblVal2.Text = "Value:"

        DM_Reading2 = "D60"
        Alarm_Reading2 = "C53.12"

        ThreeVal_Read = False

        ShowSenVal_Form.ShowDialog()
    End Sub
End Class