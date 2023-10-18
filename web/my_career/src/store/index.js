import Vuex from 'vuex';
import VuexPersistence from 'vuex-persist';

const store = new Vuex.Store({
    state() {
        return {
            freelance: {
                sectionNo: 1
            }
        }
    },
    getters: {
        getSectionNo: state => {
            return state.freelance.sectionNo;
        }
    },
    mutations: {
        setSectionNo(state, payload) {
            state.freelance.sectionNo = payload;
        }
    },
    actions: {
        setSectionNo({commit}, payload) {
            commit('setSectionNo', payload);
        }
    },
    plugins: [new VuexPersistence().plugin]
});

export default store;