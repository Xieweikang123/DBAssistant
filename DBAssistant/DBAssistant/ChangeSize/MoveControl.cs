using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonLib;

namespace CommonLib
{
    public class MoveControl
    {
        public Control lblMsg;

        #region Constructors
        public MoveControl(Control ctrl)
        {
            currentControl = ctrl;
            AddEvents();
        }
        #endregion

        #region Fields
        private Control currentControl; //传入的控件
        private Point pPoint; //上个鼠标坐标
        private Point cPoint; //当前鼠标坐标
        public FrameControl fc;//边框控件
        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// 挂载事件
        /// </summary>
        private void AddEvents()
        {
            currentControl.MouseClick += new MouseEventHandler(MouseClick);
            currentControl.MouseDown += new MouseEventHandler(MouseDown);
            currentControl.MouseMove += new MouseEventHandler(MouseMove);
            currentControl.MouseUp += new MouseEventHandler(MouseUp);
        }

        /// <summary>
        /// 绘制拖拉时的带颜色边框
        /// </summary>
        public static void DrawDragBound(Control ctrl)
        {
            ctrl.Refresh();
            Graphics g = ctrl.CreateGraphics();
            int width = ctrl.Width;
            int height = ctrl.Height;
            Point[] ps = new Point[5]{new Point(0,0),new Point(width-2,0),
                new Point(width-2 ,height -1),new Point(0,height-1),new Point(0,0)};
            g.DrawLines(new Pen(Color.Red), ps);
        }
        #endregion

        #region Events
        /// <summary>
        /// 鼠标单击事件：用来显示边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MouseClick(object sender, MouseEventArgs e)
        {
            this.currentControl.Parent.Refresh();//刷新父容器，清除掉其他控件的边框
            this.currentControl.BringToFront();
            fc = new FrameControl(this.currentControl);
            fc.lblMsg = this.lblMsg;
            this.currentControl.Parent.Controls.Add(fc);
            fc.Visible = true;
            fc.Draw();
        }

        /// <summary>
        /// 鼠标按下事件：记录当前鼠标相对窗体的坐标
        /// </summary>
        void MouseDown(object sender, MouseEventArgs e)
        {
            pPoint = Cursor.Position;
        }

        /// <summary>
        /// 鼠标移动事件：让控件跟着鼠标移动
        /// </summary>
        void MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.SizeAll; //当鼠标处于控件内部时，显示光标样式为SizeAll

            //当鼠标左键按下时才触发
            if (e.Button == MouseButtons.Left)
            {
                MoveControl.DrawDragBound(this.currentControl);
                if (fc != null) fc.Visible = false; //先隐藏
                cPoint = Cursor.Position; //获得当前鼠标位置
                int x = cPoint.X - pPoint.X;
                int y = cPoint.Y - pPoint.Y;
                currentControl.Location = new Point(currentControl.Location.X + x, currentControl.Location.Y + y);
                pPoint = cPoint;
            }
        }

        /// <summary>
        /// 鼠标弹起事件：让自定义的边框出现
        /// </summary>
        void MouseUp(object sender, MouseEventArgs e)
        {
            this.currentControl.Refresh();
            if (fc != null)
            {
                fc.Visible = true;
                fc.Draw();
            }
        }
        #endregion
    }
}
