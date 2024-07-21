﻿using Kiosk.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.pPanel
{
    public partial class KioskPanel : UserControl
    {
        pPanel.CartPanel cartPanel = new pPanel.CartPanel();
        public event EventHandler ButtonClicked;

        public KioskPanel()
        {
            InitializeComponent();
            AddFromKioskLayoutPanel();
        }

        #region 키오스크 버튼 동적 생성 및 DB 담기
        public void AddFromKioskLayoutPanel()
        {
            ItemInsert itemInsert = new ItemInsert();
            List<Button> btnList = itemInsert.CheckItem();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            int columnCount = 4; // 한 줄에 보여질 최대 열 수
            int itemCount = btnList.Count;

            // 필요한 행 수 계산
            int rowCount = (int)Math.Ceiling((double)itemCount / columnCount);

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            // 열 스타일 설정
            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));
            }

            // 행 스타일 설정
            for (int y = 0; y < rowCount; y++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            // 버튼 추가 및 클릭 이벤트 핸들러 등록
            for (int index = 0; index < itemCount; index++)
            {
                int x = index % columnCount;
                int y = index / columnCount;

                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle
                };

                Button button = btnList[index];
                button.Dock = DockStyle.Fill;

                panel.Controls.Add(button);
                tableLayoutPanel1.Controls.Add(panel, x, y);

                // 버튼 클릭 이벤트 핸들러 추가
                button.Click += (sender, e) =>
                {
                    var itemData = (dynamic)button.Tag;
                    
                    string itemName = itemData.itemName; // 상품 이름
                    int itemPrice = itemData.price; // 상품 가격
                    string itemContent = itemData.content; // 상품 상세설명
                    

                    //itemInsert.InsertItem(optionName, optionPrice, optionContent);
                    
                    //새로운 폼을 생성
                    item itemForm = new item(itemName, itemPrice, itemContent);
                    itemForm.Show();


                    /* 폼 띄우기0
                        
                    폼에 클릭한 상품 정보 띄우기 (상품 이미지 , 상품 이름0 , 가격0 , 상세설명0 , 옵션 )
                    상품 이미지 다운로드 할 수 있는 창 , 이미지를 저장 할 로컬 경로

                    옵션 체크박스?, 버튼?
                    
                    옵션 나오게 하는거 어떻게 할건지 생각해보기 똑같이 버튼으로도 가능

                    장바구니 테이블 생각하기 (옵션 값을 db에 저장 할때 어떻게 집어넣을지)

                    테이블 간 관계설정 1 : N 을 이용해 kiosktable 에 저장
                    예 ) FOREIGN KEY(optionidx) REFERENCES optiontable(idx) 로 관계설정

                    장바구니 panel 에 띄우기  장바구니의 상품별 옵션값은 어떻게 담을지 생각해보기
                    
                    장바구니 panel 에서 결제 버튼을 누르면 orderttable 에 저장
                    */

                };
                
            }
        }
        #endregion


        public void button4_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
