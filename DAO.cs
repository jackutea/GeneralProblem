using System;
using System.Collections.Generic;

namespace GP.DAOSample {

    internal struct RoleEntity {
        public int id;
    }

    // DAO: Data Access Object
    // Please implement following methods
    internal class ReleDAO {

        void Add(RoleEntity role) {
            throw new NotImplementedException();
        }

        public void Remove(RoleEntity role) {
            throw new NotImplementedException();
        }

        public bool TryGet(int id, out RoleEntity role) {
            throw new NotImplementedException();
        }

        public void Foreach(Action<RoleEntity> action) {
            throw new NotImplementedException();
        }

    }

}