namespace GP.L6 {

    public struct Vector2 {
        public float x;
        public float y;
    }

    public struct Line {
        public Vector2 a;
        public Vector2 b;
    }

    public struct Triangle {
        public Vector2 a;
        public Vector2 b;
        public Vector2 c;
    }

    public struct Convex {
        public Vector2[] vertices;
    }

    // Please implement following methods
    public static class Physics2D_Hard {

        public static bool IsIntersect(Line a, Line b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Triangle a, Triangle b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Line a, Triangle b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Line a, Convex b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Triangle a, Convex b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Convex a, Convex b) {
            throw new System.NotImplementedException();
        }

    }

}