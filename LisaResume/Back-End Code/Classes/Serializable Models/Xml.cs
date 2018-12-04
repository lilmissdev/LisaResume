
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class root
{

    private rootRootOfJson rootOfJsonField;

    /// <remarks/>
    public rootRootOfJson rootOfJson
    {
        get
        {
            return this.rootOfJsonField;
        }
        set
        {
            this.rootOfJsonField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJson
{

    private rootRootOfJsonBasics basicsField;

    private rootRootOfJsonEducation educationField;

    private string[] interestsField;

    private rootRootOfJsonLocation locationField;

    private rootRootOfJsonElement[] referencesField;

    private string[] skillsField;

    private rootRootOfJsonVolunteer volunteerField;

    private rootRootOfJsonElement1[] workField;

    /// <remarks/>
    public rootRootOfJsonBasics basics
    {
        get
        {
            return this.basicsField;
        }
        set
        {
            this.basicsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonEducation education
    {
        get
        {
            return this.educationField;
        }
        set
        {
            this.educationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] interests
    {
        get
        {
            return this.interestsField;
        }
        set
        {
            this.interestsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public rootRootOfJsonElement[] references
    {
        get
        {
            return this.referencesField;
        }
        set
        {
            this.referencesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] skills
    {
        get
        {
            return this.skillsField;
        }
        set
        {
            this.skillsField = value;
        }
    }

    /// <remarks/>
    public rootRootOfJsonVolunteer volunteer
    {
        get
        {
            return this.volunteerField;
        }
        set
        {
            this.volunteerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public rootRootOfJsonElement1[] work
    {
        get
        {
            return this.workField;
        }
        set
        {
            this.workField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonBasics
{

    private string emailField;

    private string labelField;

    private string nameField;

    private string phoneField;

    private object pictureField;

    private string summaryField;

    private string[] websiteField;

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public string label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }

    /// <remarks/>
    public object picture
    {
        get
        {
            return this.pictureField;
        }
        set
        {
            this.pictureField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonEducation
{

    private rootRootOfJsonEducationElement elementField;

    /// <remarks/>
    public rootRootOfJsonEducationElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonEducationElement
{

    private string areaField;

    private string[] coursesField;

    private string endDateField;

    private decimal gpaField;

    private string institutionField;

    private string startDateField;

    private string websiteField;

    /// <remarks/>
    public string area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
    public string[] courses
    {
        get
        {
            return this.coursesField;
        }
        set
        {
            this.coursesField = value;
        }
    }

    /// <remarks/>
    public string endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public decimal gpa
    {
        get
        {
            return this.gpaField;
        }
        set
        {
            this.gpaField = value;
        }
    }

    /// <remarks/>
    public string institution
    {
        get
        {
            return this.institutionField;
        }
        set
        {
            this.institutionField = value;
        }
    }

    /// <remarks/>
    public string startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonLocation
{

    private string addressField;

    private string cityField;

    private string countryCodeField;

    private string postalCodeField;

    private string regionField;

    /// <remarks/>
    public string address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string countryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    public string postalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <remarks/>
    public string region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonElement
{

    private string companyField;

    private string contactField;

    private string nameField;

    private string positionField;

    /// <remarks/>
    public string company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }

    /// <remarks/>
    public string contact
    {
        get
        {
            return this.contactField;
        }
        set
        {
            this.contactField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonVolunteer
{

    private rootRootOfJsonVolunteerElement elementField;

    /// <remarks/>
    public rootRootOfJsonVolunteerElement element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonVolunteerElement
{

    private ushort endDateField;

    private string organizationField;

    private string positionField;

    private ushort startDateField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    public ushort endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public string organization
    {
        get
        {
            return this.organizationField;
        }
        set
        {
            this.organizationField = value;
        }
    }

    /// <remarks/>
    public string position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public ushort startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootRootOfJsonElement1
{

    private string companyField;

    private string endDateField;

    private string positionField;

    private string startDateField;

    private string summaryField;

    private string websiteField;

    /// <remarks/>
    public string company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }

    /// <remarks/>
    public string endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public string position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string startDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public string summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public string website
    {
        get
        {
            return this.websiteField;
        }
        set
        {
            this.websiteField = value;
        }
    }
}

