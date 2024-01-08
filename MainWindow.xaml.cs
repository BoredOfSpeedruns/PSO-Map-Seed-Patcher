using System.Text;
using System.Diagnostics;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PSO_Patcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    using pso;
    using System.Collections.Generic;

    public partial class MainWindow : Window
    {
        public static codecave mapCodeCave = new codecave();
        public static codecave nameCodeCave = new codecave();
        public static codecave saveCodeCave = new codecave();

        // Global Default Bytes
        byte[] oldMapBytes  = new byte[80];
        MapBytes forest_1   = new MapBytes("forest_1");
        MapBytes forest_2   = new MapBytes("forest_2");
        MapBytes caves_1    = new MapBytes("caves_1");
        MapBytes caves_2    = new MapBytes("caves_2");
        MapBytes caves_3    = new MapBytes("caves_3");
        MapBytes mines_1    = new MapBytes("mines_1");
        MapBytes mines_2    = new MapBytes("mines_2");
        MapBytes ruins_1    = new MapBytes("ruins_1");
        MapBytes ruins_2    = new MapBytes("ruins_2");
        MapBytes ruins_3    = new MapBytes("ruins_3");
        psoapi pso          = new psoapi("pso");

        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void Forest_1_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation A":
                    forest_1.Byte_1 = 0x00;
                    forest_1.Byte_2 = 0x00;
                    break;
                case "Variation B":
                    forest_1.Byte_1 = 0x00;
                    forest_1.Byte_2 = 0x01;
                    break;
                case "Variation C":
                    forest_1.Byte_1 = 0x00;
                    forest_1.Byte_2 = 0x02;
                    break;
                default:
                    forest_1.Byte_1 = 0x00;
                    forest_1.Byte_2 = 0x00;
                    break;
            }
        }
        private void Forest_2_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation A":
                    forest_2.Byte_1 = 0x00;
                    forest_2.Byte_2 = 0x00;
                    break;
                case "Variation B":
                    forest_2.Byte_1 = 0x00;
                    forest_2.Byte_2 = 0x01;
                    break;
                case "Variation C":
                    forest_2.Byte_1 = 0x00;
                    forest_2.Byte_2 = 0x02;
                    break;
                default:
                    forest_2.Byte_1 = 0x00;
                    forest_2.Byte_2 = 0x00;
                    break;
            }
        }
        private void Caves_1_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation A":
                    caves_1.Byte_1 = 0x00;
                    caves_1.Byte_2 = 0x00;
                    break;
                case "Variation B":
                    caves_1.Byte_1 = 0x01;
                    caves_1.Byte_2 = 0x00;
                    break;
                case "Variation C":
                    caves_1.Byte_1 = 0x02;
                    caves_1.Byte_2 = 0x00;
                    break;
                default:
                    caves_1.Byte_1 = 0x00;
                    caves_1.Byte_2 = 0x00;
                    break;
            }
        }
        private void Caves_2_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation A":
                    caves_2.Byte_1 = 0x00;
                    caves_2.Byte_2 = 0x00;
                    break;
                case "Variation B":
                    caves_2.Byte_1 = 0x01;
                    caves_2.Byte_2 = 0x00;
                    break;
                case "Variation C":
                    caves_2.Byte_1 = 0x02;
                    caves_2.Byte_2 = 0x00;
                    break;
                default:
                    caves_2.Byte_1 = 0x00;
                    caves_2.Byte_2 = 0x00;
                    break;
            }
        }
        private void Caves_3_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation A":
                    caves_3.Byte_1 = 0x00;
                    caves_3.Byte_2 = 0x00;
                    break;
                case "Variation B":
                    caves_3.Byte_1 = 0x01;
                    caves_3.Byte_2 = 0x00;
                    break;
                case "Variation C":
                    caves_3.Byte_1 = 0x02;
                    caves_3.Byte_2 = 0x00;
                    break;
                default:
                    caves_3.Byte_1 = 0x00;
                    caves_3.Byte_2 = 0x00;
                    break;
            }
        }
        private void Mines_1_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation 1A":
                    mines_1.Byte_1 = 0x00;
                    mines_1.Byte_2 = 0x00;
                    break;
                case "Variation 1B":
                    mines_1.Byte_1 = 0x00;
                    mines_1.Byte_2 = 0x01;
                    break;
                case "Variation 2A":
                    mines_1.Byte_1 = 0x01;
                    mines_1.Byte_2 = 0x00;
                    break;
                case "Variation 2B":
                    mines_1.Byte_1 = 0x01;
                    mines_1.Byte_2 = 0x01;
                    break;
                case "Variation 3A":
                    mines_1.Byte_1 = 0x02;
                    mines_1.Byte_2 = 0x00;
                    break;
                case "Variation 3B":
                    mines_1.Byte_1 = 0x02;
                    mines_1.Byte_2 = 0x01;
                    break;
                default:
                    mines_1.Byte_1 = 0x00;
                    mines_1.Byte_2 = 0x00;
                    break;
            }
        }
        private void Mines_2_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation 1A":
                    mines_2.Byte_1 = 0x00;
                    mines_2.Byte_2 = 0x00;
                    break;
                case "Variation 1B":
                    mines_2.Byte_1 = 0x00;
                    mines_2.Byte_2 = 0x01;
                    break;
                case "Variation 2A":
                    mines_2.Byte_1 = 0x01;
                    mines_2.Byte_2 = 0x00;
                    break;
                case "Variation 2B":
                    mines_2.Byte_1 = 0x01;
                    mines_2.Byte_2 = 0x01;
                    break;
                case "Variation 3A":
                    mines_2.Byte_1 = 0x02;
                    mines_2.Byte_2 = 0x00;
                    break;
                case "Variation 3B":
                    mines_2.Byte_1 = 0x02;
                    mines_2.Byte_2 = 0x01;
                    break;
                default:
                    mines_2.Byte_1 = 0x00;
                    mines_2.Byte_2 = 0x00;
                    break;
            }
        }
        private void Ruins_1_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation 1A":
                    ruins_1.Byte_1 = 0x00;
                    ruins_1.Byte_2 = 0x00;
                    break;
                case "Variation 1B":
                    ruins_1.Byte_1 = 0x00;
                    ruins_1.Byte_2 = 0x01;
                    break;
                case "Variation 2A":
                    ruins_1.Byte_1 = 0x01;
                    ruins_1.Byte_2 = 0x00;
                    break;
                case "Variation 2B":
                    ruins_1.Byte_1 = 0x01;
                    ruins_1.Byte_2 = 0x01;
                    break;
                case "Variation 3A":
                    ruins_1.Byte_1 = 0x02;
                    ruins_1.Byte_2 = 0x00;
                    break;
                case "Variation 3B":
                    ruins_1.Byte_1 = 0x02;
                    ruins_1.Byte_2 = 0x01;
                    break;
                default:
                    ruins_1.Byte_1 = 0x00;
                    ruins_1.Byte_2 = 0x00;
                    break;
            }
        }
        private void Ruins_2_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation 1A":
                    ruins_2.Byte_1 = 0x00;
                    ruins_2.Byte_2 = 0x00;
                    break;
                case "Variation 1B":
                    ruins_2.Byte_1 = 0x00;
                    ruins_2.Byte_2 = 0x01;
                    break;
                case "Variation 2A":
                    ruins_2.Byte_1 = 0x01;
                    ruins_2.Byte_2 = 0x00;
                    break;
                case "Variation 2B":
                    ruins_2.Byte_1 = 0x01;
                    ruins_2.Byte_2 = 0x01;
                    break;
                case "Variation 3A":
                    ruins_2.Byte_1 = 0x02;
                    ruins_2.Byte_2 = 0x00;
                    break;
                case "Variation 3B":
                    ruins_2.Byte_1 = 0x02;
                    ruins_2.Byte_2 = 0x01;
                    break;
                default:
                    ruins_2.Byte_1 = 0x00;
                    ruins_2.Byte_2 = 0x00;
                    break;
            }
        }
        private void Ruins_3_dd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string val = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (val)
            {
                case "Variation 1A":
                    ruins_3.Byte_1 = 0x00;
                    ruins_3.Byte_2 = 0x00;
                    break;
                case "Variation 1B":
                    ruins_3.Byte_1 = 0x00;
                    ruins_3.Byte_2 = 0x01;
                    break;
                case "Variation 2A":
                    ruins_3.Byte_1 = 0x01;
                    ruins_3.Byte_2 = 0x00;
                    break;
                case "Variation 2B":
                    ruins_3.Byte_1 = 0x01;
                    ruins_3.Byte_2 = 0x01;
                    break;
                case "Variation 3A":
                    ruins_3.Byte_1 = 0x02;
                    ruins_3.Byte_2 = 0x00;
                    break;
                case "Variation 3B":
                    ruins_3.Byte_1 = 0x02;
                    ruins_3.Byte_2 = 0x01;
                    break;
                default:
                    ruins_3.Byte_1 = 0x00;
                    ruins_3.Byte_2 = 0x00;
                    break;
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            byte[] mapBytes = pso.ReadBytes((int)forest_1.addr, 80);
            if(mapBytes == oldMapBytes)
            {
                return;
            }
            
            oldMapBytes = mapBytes;

            Label f1 = (Label)this.FindName("Forest_1");
            f1.Content = forest_1.getMapVariation(pso);

            Label f2 = (Label)this.FindName("Forest_2");
            f2.Content = forest_2.getMapVariation(pso);

            Label c1 = (Label)this.FindName("Caves_1");
            c1.Content = caves_1.getMapVariation(pso);

            Label c2 = (Label)this.FindName("Caves_2");
            c2.Content = caves_2.getMapVariation(pso);

            Label c3 = (Label)this.FindName("Caves_3");
            c3.Content = caves_3.getMapVariation(pso);

            Label m1 = (Label)this.FindName("Mines_1");
            m1.Content = mines_1.getMapVariation(pso);

            Label m2 = (Label)this.FindName("Mines_2");
            m2.Content = mines_2.getMapVariation(pso);

            Label r1 = (Label)this.FindName("Ruins_1");
            r1.Content = ruins_1.getMapVariation(pso);

            Label r2 = (Label)this.FindName("Ruins_2");
            r2.Content = ruins_2.getMapVariation(pso);

            Label r3 = (Label)this.FindName("Ruins_3");
            r3.Content = ruins_3.getMapVariation(pso);


        }
        private void Patch_Btn_Click(object sender, RoutedEventArgs e)
        {
            // Create Seed Patch
            byte[] patchSeed = new byte[317]
            {
                0x81, 0xFF, 0x80, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+333080
                0x74, 0x75,                                             // je 0081007D
                0x0F, 0x1F, 0x40, 0x00,                                 // nop dword ptr [eax+00]
                0x81, 0xFF, 0x88, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+333088
                0x74, 0x78,                                             // je 0081008C
                0x0F, 0x1F, 0x40, 0x00,                                 // nop dword ptr [eax+00]
                0x81, 0xFF, 0x90, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+333090
                0x74, 0x7B,                                             // je 0081009B
                0x0F, 0x1F, 0x40, 0x00,                                 // nop dword ptr [eax+00]
                0x81, 0xFF, 0x98, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+333098
                0x74, 0x7E,                                             // je 008100AA
                0x0F, 0x1F, 0x40, 0x00,                                 // nop dword ptr [eax+00]
                0x81, 0xFF, 0xA0, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330A0
                0x0F, 0x84, 0x7D, 0x00, 0x00, 0x00,                     // je 008100B9
                0x81, 0xFF, 0xA8, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330A8
                0x0F, 0x84, 0x80, 0x00, 0x00, 0x00,                     // je 008100C8
                0x81, 0xFF, 0xB0, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330B0
                0x0F, 0x84, 0x83, 0x00, 0x00, 0x00,                     // je 008100D7
                0x81, 0xFF, 0xB8, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330B8
                0x0F, 0x84, 0x86, 0x00, 0x00, 0x00,                     // je 008100E6
                0x81, 0xFF, 0xC0, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330C0
                0x0F, 0x84, 0x89, 0x00, 0x00, 0x00,                     // je 008100F5
                0x81, 0xFF, 0xC8, 0x30, 0x73, 0x00,                     // cmp edi,pso.exe+3330C8
                0x0F, 0x84, 0x8C, 0x00, 0x00, 0x00,                     // je 00810104
                0xE9, 0x96, 0x00, 0x00, 0x00,                           // jmp 00810113
                0xB8, forest_1.Byte_1, 0x00, 0x00, 0x00,                // mov eax,00000000
                0xBA, forest_1.Byte_2, 0x00, 0x00, 0x00,                // mov edx,00000001
                0xE9, 0x96, 0x00, 0x00, 0x00,                           // jmp 00810122
                0xB8, forest_2.Byte_1, 0x00, 0x00, 0x00,                // mov eax,00000000
                0xBA, forest_2.Byte_2, 0x00, 0x00, 0x00,                // mov edx,00000000
                0xE9, 0x87, 0x00, 0x00, 0x00,                           // jmp 00810122
                0xB8, caves_1.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000002
                0xBA, caves_1.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000000
                0xEB, 0x7B,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, caves_2.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000002
                0xBA, caves_2.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000000
                0xEB, 0x6C,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, caves_3.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000002
                0xBA, caves_3.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000000
                0xEB, 0x5D,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, mines_1.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000002
                0xBA, mines_1.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000001
                0xEB, 0x4E,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, mines_1.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000002
                0xBA, mines_1.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000001
                0xEB, 0x3F,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, ruins_1.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000000
                0xBA, ruins_1.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000001
                0xEB, 0x30,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, ruins_2.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000000
                0xBA, ruins_2.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000001
                0xEB, 0x21,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, ruins_3.Byte_1, 0x00, 0x00, 0x00,                 // mov eax,00000000
                0xBA, ruins_3.Byte_2, 0x00, 0x00, 0x00,                 // mov edx,00000001
                0xEB, 0x12,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0xB8, 0x00, 0x00, 0x00, 0x00,                           // mov eax,00000000
                0xBA, 0x00, 0x00, 0x00, 0x00,                           // mov edx,00000000
                0xEB, 0x03,                                             // jmp 00810122
                0x0F, 0x1F, 0x00,                                       // nop dword ptr [eax]
                0x89, 0x07,                                             // mov [edi],eax
                0x89, 0x44, 0x24, 0x0C,                                 // mov [esp+0C],eax
                0xDB, 0x44, 0x24, 0x0C,                                 // fild dword ptr [esp+0C]
                0xD8, 0x0D, 0x24, 0xD5, 0x64, 0x00,                     // fmul dword ptr [pso.exe+24D524]
                0xDA, 0x8E, 0x44, 0xFC, 0x66, 0x00,                     // fimul [esi+pso.exe+26FC44]
                0x8B, 0xC2,                                             // mov eax,edx
                0x89, 0x47, 0x04,                                       // mov [edi+04],eax
            };

            mapCodeCave = pso.createCodeCave(0x1A8F20, 35, mapCodeCave, patchSeed);

            nameCodeCave = pso.createCodeCave(0x171881, 8, nameCodeCave);

            IntPtr originalNameStore = nameCodeCave.AllocBaseAddr + 0xC8;
            byte[] nameStoreAlloc = pso.ConvertIntPtrToArray(originalNameStore);
            byte offset_1 = 0xCC;
            byte offset_2 = 0xD0;

            // Create Name Patch
            byte[] patchNamePERM = new byte[]
            {
                0x8D, 0xB2, 0x70, 0x03, 0x00, 0x00,                                                             // lea esi, [edx+00000370]
                0x8B, 0x1E,                                                                                     // mov ebx, [esi]
                0x89, 0x1D, nameStoreAlloc[0], nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],         // mov [Offset], ebx
                0x8B, 0x5E, 0x04,                                                                               // mov ebx, [esi+4]
                0x89, 0x1D, offset_1, nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],                  // mov [Offset + 4], ebx
                0x8B, 0x5E, 0x08,                                                                               // mov ebx, [esi+8]
                0x89, 0x1D, offset_2, nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],                  // mov [Offset + 8], ebx
                0xBB, 0x53, 0x00, 0x00, 0x00,                                                                   // mov ebx, 53
                0x89, 0x1E,                                                                                     // mov [esi], ebx
                0xBB, 0x65, 0x00, 0x00, 0x00,                                                                   // mov ebx, 65
                0x89, 0x5E, 0x01,                                                                               // mov [esi+1], ebx
                0xBB, 0x74, 0x00, 0x00, 0x00,                                                                   // mov ebx, 74
                0x89, 0x5E, 0x02,                                                                               // mov [esi+2], ebx
                0xBB, 0x53, 0x00, 0x00, 0x00,                                                                   // mov ebx, 53
                0x89, 0x5E, 0x03,                                                                               // mov [esi+3], ebx
                0xBB, 0x65, 0x00, 0x00, 0x00,                                                                   // mov ebx, 65
                0x89, 0x5E, 0x04,                                                                               // mov [esi+4], ebx
                0xBB, 0x65, 0x00, 0x00, 0x00,                                                                   // mov ebx, 65
                0x89, 0x5E, 0x05,                                                                               // mov [esi+4], ebx
                0xBB, 0x64, 0x00, 0x00, 0x00,                                                                   // mov ebx, 64
                0x89, 0x5E, 0x06,                                                                               // mov [esi+5], ebx
                0xBB, 0x00, 0x00, 0x00, 0x00,                                                                   // mov ebx, 00
                0x89, 0x5E, 0x07,                                                                               // mov [esi+6], ebx
                0xBB, 0x00, 0x00, 0x00, 0x00,                                                                   // mov ebx, 00
                0x89, 0x5E, 0x08,                                                                               // mov [exi+7], ebx
                0xF3, 0xA5                                                                                      // repe movsd
            };

            pso.WriteBytesCodeCave(nameCodeCave.AllocBaseAddr, patchNamePERM);
            pso.CreateJump(0x171881, nameCodeCave.AllocBaseAddr + patchNamePERM.Length, 8, true);

            byte[] savePatch = new byte[]
            {
                0x89, 0x8D, 0x50, 0x03, 0x00, 0x00,                                                             // mov [ebp+00000350],ecx
                0x8B, 0x05, nameStoreAlloc[0], nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],         // mov eax, [Offset]
                0x89, 0x85, 0x04, 0x08, 0x00, 0x00,                                                             // mov [ebp+804], eax
                0x8B, 0x05, offset_1, nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],                  // mov eax, [Offset + 4]
                0x89, 0x85, 0x08, 0x08, 0x00, 0x00,                                                             // mov [ebp+808], eax
                0x8B, 0x05, offset_2, nameStoreAlloc[1], nameStoreAlloc[2], nameStoreAlloc[3],                  // mov eax, [Offset + 8]
                0x89, 0x85, 0x0C, 0x08, 0x00, 0x00,                                                             // mov [ebp+80C], eax
                0x8D, 0xB5, 0x04, 0x08, 0x00, 0x00,                                                             // lea esi,[ebp+00000804]
                0x8D, 0xBB, 0x70, 0x03, 0x00, 0x00                                                              // lea edi,[ebx+00000370]
            };
            saveCodeCave = pso.createCodeCave(0x17965A, 18, saveCodeCave, savePatch);
        }
    }
}