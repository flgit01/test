using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
 using DevExpress.XtraTreeList.Nodes;

namespace treelist03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.district”中。您可以根据需要移动或删除它。
            // this.districtTableAdapter.Fill(this.studentDataSet.district);
            //数据库连接字符串
            string connectionString = "Data Source=.;Database=student;Integrated Security=SSPI";
            //创建数据库连接实例
            SqlConnection connection = new SqlConnection(connectionString);
            //打开数据库连接
            //connection.Open();
            // SqlCommand cmd = new SqlCommand(connectionString);
             //cmd.CommandText = "SELECT * FROM  students";
            string sql = "SELECT * FROM  district";
             
            //MessageBox.Show("数据库连接成功 ");  //winform程序
             SqlDataAdapter sda = new SqlDataAdapter(sql, connection);

             DataTable  table=new DataTable();
             sda.Fill(table);
           
             treeList1.DataSource = table;
             treeList1.KeyFieldName = "KeyFieldName";    
             treeList1.ParentFieldName = "ParentFieldName";
              treeList1.Columns["cityname"].Caption = "城市";   
            // treeList1.OptionsView.ShowCheckBoxes = true;
             
 
        }

        ///// <summary>
        ///// 设置子节点的状态
        ///// </summary>
        ///// <param name="node"></param>
        ///// <param name="check"></param>
        //private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        //{
        //    for (int i = 0; i < node.Nodes.Count; i++)
        //    {
        //        node.Nodes[i].CheckState = check;
        //        SetCheckedChildNodes(node.Nodes[i], check);
        //    }
        //}

        ///// <summary>
        ///// 设置父节点的状态
        ///// </summary>
        ///// <param name="node"></param>
        ///// <param name="check"></param>
        //private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        //{
        //    if (node.ParentNode != null)
        //    {
        //        bool b = false;
        //        CheckState state;
        //        for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
        //        {
        //            state = (CheckState)node.ParentNode.Nodes[i].CheckState;
        //            if (!check.Equals(state))
        //            {
        //                b = !b;
        //                break;
        //            }
        //        }
        //        node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
        //        SetCheckedParentNodes(node.ParentNode, check);
        //    }
        //}
        ///// <summary>
        ///// 动态创建TreeList Layer Node节点
        ///// </summary>
        ///// <param name="layerName"></param>
        ///// <param name="check"></param>
        //private void creatMainLayerNode(string layerName, bool check)
        //{
        //    this.treeList1.BeginUnboundLoad();
        //    this.treeList1.AppendNode(new object[] { layerName, check }, -1);
        //    this.treeList1.EndUnboundLoad();
        //}
        ///// <summary>
        ///// 动态创建TreeList 字段属性值 Node节点
        ///// </summary>
        ///// <param name="ValueName"></param>
        ///// <param name="check"></param>
        ///// <param name="ID"></param>
        //private void CreatChildNode(string ValueName, bool check, int ID)
        //{
        //    this.treeList1.BeginUnboundLoad();
        //    this.treeList1.AppendNode(new object[] { ValueName, check }, ID);
        //    this.treeList1.EndUnboundLoad();
        //}
        ///// <summary>

        ///// 点击节点前

        ///// </summary>

        ///// <param name="sender"></param>

        ///// <param name="e"></param>

        //private void treeLstModuleAction_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        //{

        //    e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);

        //}
        ///// <summary>

        ///// 点击节点后

        ///// </summary>

        ///// <param name="sender"></param>

        ///// <param name="e"></param>

        //private void treeLstModuleAction_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        //{

        //    SetCheckedChildNodes(e.Node, e.Node.CheckState);

        //    SetCheckedParentNodes(e.Node, e.Node.CheckState);

        //}

        /// <summary>

        /// 选择子节点时触发

        /// </summary>

        /// <param name="node"></param>

        /// <param name="check"></param>

        //private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        //{

        //    for (int i = 0; i < node.Nodes.Count; i++)
        //    {

        //        node.Nodes[i].CheckState = check;

        //       SetCheckedChildNodes(node.Nodes[i], check);
        //       SetCheckedParentNodes(node.ParentNode, check);

        //    }

        //}

        /// <summary>

        /// 选择父节点时触发

        /// </summary>

        /// <param name="node"></param>

        /// <param name="check"></param>

        //private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        //{

        //    if (node.ParentNode != null)
        //    {

        //        bool b = false;

        //        CheckState state;

        //        for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
        //        {

        //            state = (CheckState)node.ParentNode.Nodes[i].CheckState;

        //            if (!check.Equals(state))
        //            {

        //                b = !b;

        //                break;

        //            }

        //        }

        //        node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;

        //        SetCheckedParentNodes(node.ParentNode, check);

        //    }

        //}

        /// <summary>

        /// 判断此节点下的所有孩子节点是否选中

        /// </summary>

        /// <param name="node"></param>

        /// <returns></returns>

        //private Boolean IsChildsChecked(TreeListNode node)
        //{

        //    for (int i = 0; i < node.Nodes.Count; i++)
        //    {

        //        if (node.Nodes[i].CheckState == CheckState.Unchecked)
        //               return false;
                                                          
        //        if (node.Nodes[i].HasChildren)

        //            IsChildsChecked(node.Nodes[i]);

        //    }

        //    return true;

        //}


        
    
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
    {
        DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumncityname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
        treeListColumncityname.Caption = "名称";
        treeListColumncityname.FieldName = "cityname";
        treeListColumncityname.Name = "treeListColumncityname";

    }

      

    }
}
