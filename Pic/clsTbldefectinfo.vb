
Public Class clsTbldefectinfo

    Private m_id As Integer 'ID
    Private m_machine As String '编织机号
    Private m_knitting_date As String '编织日期
    Private m_knitting_shift As Integer '编织轮换代码
    Private m_knitting_shif_name As String '编织轮换名
    Private m_defect_item As String '不良项目
    Private m_defect_code As String '不良代号
    Private m_defect_qty As Integer '不良品数量枚
    Private m_insert_user As String '输入者
    Private m_insert_date As String '输入日期
    Private m_update_date As String '修改日期
    Private m_CECDB_DEFECT_ID As Integer '从CECDB数据库的不良品表获得的ID番号，便于今后管理

    ''' <summary>
    ''' ID
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property



    ''' <summary>
    ''' 编织机号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property machine() As String
        Get
            Return m_machine
        End Get
        Set(ByVal value As String)
            m_machine = value
        End Set
    End Property


    ''' <summary>
    ''' 编织日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property knitting_date() As String
        Get
            Return m_knitting_date
        End Get
        Set(ByVal value As String)
            m_knitting_date = value
        End Set
    End Property



    ''' <summary>
    ''' 编织轮换代码
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property knitting_shift() As Integer
        Get
            Return m_knitting_shift
        End Get
        Set(ByVal value As Integer)
            m_knitting_shift = value
        End Set
    End Property


    ''' <summary>
    ''' 编织轮换名
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property knitting_shif_name() As String
        Get
            Return m_knitting_shif_name
        End Get
        Set(ByVal value As String)
            m_knitting_shif_name = value
        End Set
    End Property

    ''' <summary>
    ''' 不良项目
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property defect_item() As String
        Get
            Return m_defect_item
        End Get
        Set(ByVal value As String)
            m_defect_item = value
        End Set
    End Property


    ''' <summary>
    ''' 不良代号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property defect_code() As String
        Get
            Return m_defect_code
        End Get
        Set(ByVal value As String)
            m_defect_code = value
        End Set
    End Property

    ''' <summary>
    ''' 不良品数量枚
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property defect_qty() As Integer
        Get
            Return m_defect_qty
        End Get
        Set(ByVal value As Integer)
            m_defect_qty = value
        End Set
    End Property


    ''' <summary>
    ''' 输入者
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property insert_user() As String
        Get
            Return m_defect_code
        End Get
        Set(ByVal value As String)
            m_defect_code = value
        End Set
    End Property

    ''' <summary>
    ''' 输入日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property insert_date() As String
        Get
            Return m_insert_date
        End Get
        Set(ByVal value As String)
            m_insert_date = value
        End Set
    End Property

    ''' <summary>
    ''' 修改日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property update_date() As String
        Get
            Return m_update_date
        End Get
        Set(ByVal value As String)
            m_update_date = value
        End Set
    End Property

    ''' <summary>
    ''' 从CECDB数据库的不良品表获得的ID番号，便于今后管理
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CECDB_DEFECT_ID() As Integer
        Get
            Return m_CECDB_DEFECT_ID
        End Get
        Set(ByVal value As Integer)
            m_CECDB_DEFECT_ID = value
        End Set
    End Property

End Class
