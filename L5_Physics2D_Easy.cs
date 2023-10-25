namespace GP.L5 {

    public struct Vector2 {
        public float x;
        public float y;
    }

    public struct AABB {
        public Vector2 min;
        public Vector2 max;
    }

    public struct OBB {
        public Vector2 center;
        public Vector2 size;
        public float rotation;
    }

    public struct Circle {
        public Vector2 center;
        public float radius;
    }

    // Please implement following methods
    public static class Physics2D_Easy {

        public static bool IsIntersect(AABB a, AABB b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(Circle a, Circle b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(OBB a, OBB b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(AABB a, Circle b) {
            throw new System.NotImplementedException();
        }

        public static bool IsIntersect(OBB a, Circle b) {
            throw new System.NotImplementedException();
        }

    }

}