namespace GP.EncodingHardSample {

    public struct Vector2 {
        public float x;
        public float y;
    }

    public struct RoleEntity {
        public int id;
        public string name;
        public Vector2 pos;
        public int level;
        public float moveSpeed;
        public int[] skillIDs;
    }

    // Please implement following methods
    public static class Encoding_Hard {

        // input: RoleEntity
        // output: byte[]
        public static byte[] EncodeRole(RoleEntity role) {
            throw new System.NotImplementedException();
        }

        // input: byte[]
        // output: RoleEntity
        public static RoleEntity DecodeRole(byte[] bytes) {
            throw new System.NotImplementedException();
        }

    }
}