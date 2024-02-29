using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Controls;

namespace ProvaiderEF
{
    public partial class FormZone : Form
    {
        public FormZone()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(34, 33, 74);
            LoadZone();
        }

        private void LoadZone()
        {
            // Создает экземпляр GMapControl
            gMapControl1 = new GMapControl();
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMapProviders.GoogleMap; // Выберите провайдера карт
            gMapControl1.Position = new PointLatLng(59.9343, 30.3351); // Начальные координаты
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)

            //// Добавление GMapControl на форму
            panelMap.Controls.Add(gMapControl1);

            // полигон на основе заданных координат
            List<PointLatLng> polygonPoints = new List<PointLatLng>
            {
                new PointLatLng(60.071957, 30.324463),
                new PointLatLng(59.945355, 30.207114),
                new PointLatLng(59.818135, 30.327499),
                new PointLatLng(59.945891, 30.500198)
            };

            GMapPolygon polygon = new GMapPolygon(polygonPoints, "Зона покрытия");

            // слой для полигона
            GMapOverlay polygonOverlay = new GMapOverlay("Зона покрытия");

            // Добавить полигон на слой
            polygonOverlay.Polygons.Add(polygon);

            // Добавить слой на карту
            gMapControl1.Overlays.Add(polygonOverlay);
        }

        private GMarkerGoogle GetMarker(double latitude, double longitude, int markerSize, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.red)
        {
            GMarkerGoogle mapMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), gMarkerGoogleType);//широта, долгота, тип маркера

            mapMarker.Size = new Size(markerSize, markerSize); //размер маркера (ширина и высота) в пикселях

            Font tooltipFont = new Font("Arial", 10, FontStyle.Bold); // параметры шрифта
            GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip tooltip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(mapMarker);
            tooltip.Font = tooltipFont; // Установка собственного шрифта
            mapMarker.ToolTipText = textBoxSearchAdress.Text; // текст внутри всплывающего окна
            mapMarker.ToolTip = tooltip; //всплывающее окно с инфой к маркеру
            mapMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //отображение всплывающего окна (при наведении)
            return mapMarker;
        }

        private bool IsPointInsidePolygon(PointLatLng point, GMapPolygon polygon)
        {
            return polygon.IsInside(point);
        }

        private void SearchAddress(string address)
        {
            GeoCoderStatusCode status;
            PointLatLng? point = GMapProviders.OpenStreetMap.GetPoint(address, out status);

            if (status == GeoCoderStatusCode.OK && point != null)
            {
                gMapControl1.Position = point.Value; // Перемещение карты к найденным координатам
                gMapControl1.Zoom = 12; // Установка уровня зума 

                GMapOverlay gMapMarkers = gMapControl1.Overlays.FirstOrDefault(o => o.Id == "Адреса");
                if (gMapMarkers == null)
                {
                    gMapMarkers = new GMapOverlay("Адреса");
                    gMapControl1.Overlays.Add(gMapMarkers);
                }
                else
                {
                    gMapMarkers.Markers.Clear(); // Очистить предыдущие маркеры
                }

                gMapMarkers.Markers.Add(GetMarker(point.Value.Lat, point.Value.Lng, 40)); // добавление маркера на слой
                gMapMarkers.IsVisibile = true;

                GMapOverlay polygonOverlay = gMapControl1.Overlays.FirstOrDefault(o => o.Id == "Зона покрытия");

                if (polygonOverlay != null && polygonOverlay.Polygons.Count > 0)
                {
                    GMapPolygon polygon = polygonOverlay.Polygons[0]; // есть только один полигон

                    if (IsPointInsidePolygon(point.Value, polygon))
                    {
                        lblResult.Text = "Адрес входит в зону покрытия";
                    }
                    else
                    {
                        lblResult.Text = "Адрес не входит в зону покрытия";
                    }
                }
                else
                {
                    lblResult.Text = "Нет доступных адресов для проверки.";
                }
            }
            else
            {
                MessageBox.Show("Не удалось выполнить геокодирование адреса или адрес не найден.");
                lblResult.Text = "Нет доступных адресов для проверки.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string address = textBoxSearchAdress.Text;
            SearchAddress(address);
        }
        private void textBoxSearchAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string address = textBoxSearchAdress.Text;
                SearchAddress(address);
            }
        }

        private void FormZone_FormClosing(object sender, FormClosingEventArgs e)
        {
            gMapControl1.Dispose();
            gMapControl1 = null;
        }
    }
}
