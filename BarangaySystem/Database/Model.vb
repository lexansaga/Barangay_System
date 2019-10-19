Public Class Model
    Private ID As Integer

    Private Dates As String
    Private Complainant As String
    Private Complainant_Postal_Address As String
    Private Respondent As String
    Private Respondent_Postal_Address As String
    Private Remarks As String
    Private Attached_Documents As String
    Private Received_By As String
    Private Date_Received As String


    Private blot_Incident_Type As String
    Private blot_Status As String
    Private blot_DT_Reported As String
    Private blot_DT_Incident As String
    Private blot_Incident_Narrative As String
    Private blot_Persons_Involved As String
    Private blot_Involvement As String

    Private res_Last_Name As String
    Private res_First_Name As String
    Private res_Middle_Name As String
    Private res_Aliass As String
    Private res_Purok As String
    Private res_BirthDate As String
    Private res_Civil_Status As String
    Private res_Gender As String
    Private res_Voter_Status As String
    Private res_Place_of_Birth As String
    Private res_Phone_Number As String
    Private res_Email_Address As String






    Public Sub New(iD As Integer, res_Last_Name As String, res_First_Name As String, res_Middle_Name As String, res_Aliass As String, res_Purok As String, res_BirthDate As String, res_Civil_Status As String, res_Gender As String, res_Voter_Status As String, res_Place_of_Birth As String, res_Phone_Number As String, res_Email_Address As String)
        Me.ID = iD
        Me.res_Last_Name = res_Last_Name
        Me.res_First_Name = res_First_Name
        Me.res_Middle_Name = res_Middle_Name
        Me.res_Aliass = res_Aliass
        Me.res_Purok = res_Purok
        Me.res_BirthDate = res_BirthDate
        Me.res_Civil_Status = res_Civil_Status
        Me.res_Gender = res_Gender
        Me.res_Voter_Status = res_Voter_Status
        Me.res_Place_of_Birth = res_Place_of_Birth
        Me.res_Phone_Number = res_Phone_Number
        Me.res_Email_Address = res_Email_Address
    End Sub

    Public Sub New(iD As Integer, blot_Incident_Type As String, blot_Status As String, blot_DT_Reported As String, blot_DT_Incident As String, blot_Incident_Narrative As String, blot_Persons_Involved As String, blot_Involvement As String)
        Me.ID = iD
        Me.blot_Incident_Type = blot_Incident_Type
        Me.blot_Status = blot_Status
        Me.blot_DT_Reported = blot_DT_Reported
        Me.blot_DT_Incident = blot_DT_Incident
        Me.blot_Incident_Narrative = blot_Incident_Narrative
        Me.blot_Persons_Involved = blot_Persons_Involved
        Me.blot_Involvement = blot_Involvement
    End Sub

    Public Sub New(blot_Incident_Type As String, blot_Status As String, blot_DT_Reported As String, blot_DT_Incident As String, blot_Incident_Narrative As String, blot_Persons_Involved As String, blot_Involvement As String)
        Me.blot_Incident_Type = blot_Incident_Type
        Me.blot_Status = blot_Status
        Me.blot_DT_Reported = blot_DT_Reported
        Me.blot_DT_Incident = blot_DT_Incident
        Me.blot_Incident_Narrative = blot_Incident_Narrative
        Me.blot_Persons_Involved = blot_Persons_Involved
        Me.blot_Involvement = blot_Involvement
    End Sub

    Public Sub New(iD As Integer, dates As String, complainant As String, complainant_Postal_Address As String, respondent As String, respondent_Postal_Address As String, remarks As String, attached_Documents As String, received_By As String, date_Received As String)
        Me.ID = iD
        Me.Dates = dates
        Me.Complainant = complainant
        Me.Complainant_Postal_Address = complainant_Postal_Address
        Me.Respondent = respondent
        Me.Respondent_Postal_Address = respondent_Postal_Address
        Me.Remarks = remarks
        Me.Attached_Documents = attached_Documents
        Me.Received_By = received_By
        Me.Date_Received = date_Received
    End Sub

    Public Property ID1 As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property Res_Last_Name1 As String
        Get
            Return res_Last_Name
        End Get
        Set(value As String)
            res_Last_Name = value
        End Set
    End Property

    Public Property Res_First_Name1 As String
        Get
            Return res_First_Name
        End Get
        Set(value As String)
            res_First_Name = value
        End Set
    End Property

    Public Property Res_Middle_Name1 As String
        Get
            Return res_Middle_Name
        End Get
        Set(value As String)
            res_Middle_Name = value
        End Set
    End Property

    Public Property Res_Aliass1 As String
        Get
            Return res_Aliass
        End Get
        Set(value As String)
            res_Aliass = value
        End Set
    End Property

    Public Property Res_Purok1 As String
        Get
            Return res_Purok
        End Get
        Set(value As String)
            res_Purok = value
        End Set
    End Property

    Public Property Res_BirthDate1 As String
        Get
            Return res_BirthDate
        End Get
        Set(value As String)
            res_BirthDate = value
        End Set
    End Property

    Public Property Res_Civil_Status1 As String
        Get
            Return res_Civil_Status
        End Get
        Set(value As String)
            res_Civil_Status = value
        End Set
    End Property

    Public Property Res_Gender1 As String
        Get
            Return res_Gender
        End Get
        Set(value As String)
            res_Gender = value
        End Set
    End Property

    Public Property Res_Voter_Status1 As String
        Get
            Return res_Voter_Status
        End Get
        Set(value As String)
            res_Voter_Status = value
        End Set
    End Property

    Public Property Res_Place_of_Birth1 As String
        Get
            Return res_Place_of_Birth
        End Get
        Set(value As String)
            res_Place_of_Birth = value
        End Set
    End Property

    Public Property Res_Phone_Number1 As String
        Get
            Return res_Phone_Number
        End Get
        Set(value As String)
            res_Phone_Number = value
        End Set
    End Property

    Public Property Res_Email_Address1 As String
        Get
            Return res_Email_Address
        End Get
        Set(value As String)
            res_Email_Address = value
        End Set
    End Property

    Public Property Dates1 As String
        Get
            Return Dates
        End Get
        Set(value As String)
            Dates = value
        End Set
    End Property

    Public Property Complainant1 As String
        Get
            Return Complainant
        End Get
        Set(value As String)
            Complainant = value
        End Set
    End Property

    Public Property Complainant_Postal_Address1 As String
        Get
            Return Complainant_Postal_Address
        End Get
        Set(value As String)
            Complainant_Postal_Address = value
        End Set
    End Property

    Public Property Respondent1 As String
        Get
            Return Respondent
        End Get
        Set(value As String)
            Respondent = value
        End Set
    End Property

    Public Property Respondent_Postal_Address1 As String
        Get
            Return Respondent_Postal_Address
        End Get
        Set(value As String)
            Respondent_Postal_Address = value
        End Set
    End Property

    Public Property Remarks1 As String
        Get
            Return Remarks
        End Get
        Set(value As String)
            Remarks = value
        End Set
    End Property

    Public Property Attached_Documents1 As String
        Get
            Return Attached_Documents
        End Get
        Set(value As String)
            Attached_Documents = value
        End Set
    End Property

    Public Property Received_By1 As String
        Get
            Return Received_By
        End Get
        Set(value As String)
            Received_By = value
        End Set
    End Property

    Public Property Date_Received1 As String
        Get
            Return Date_Received
        End Get
        Set(value As String)
            Date_Received = value
        End Set
    End Property
End Class
