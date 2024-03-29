﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGraphicEditor.Classes
{
    static class States
    {
        public static string DRAW_VIA_MOUSE         = "DRAW_VIA_MOUSE";
        public static string CREATE_FROM_UI         = "CREATE_FROM_UI";
        public static string MOVE_SELECTION         = "MOVE_SELECTION";
        public static string SELECTED_FIGURE_CLICKED         = "SELECTED_FIGURE_CLICKED";
        public static string RESIZE_SELECTION       = "RESIZE_SELECTION";
        public static string ROTATE_SELECTION       = "ROTATE_SELECTION";
        public static string ROTATE_SELECTION_BY_MOUSE       = "ROTATE_SELECTION_BY_MOUSE";
        public static string IDLE                   = "IDLE";
    }
}
