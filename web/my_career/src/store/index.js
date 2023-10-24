import Vuex from 'vuex';
import VuexPersistence from 'vuex-persist';

const store = new Vuex.Store({
    state() {
        return {
            freelance: {
                sectionNo: 1
            },
            components: [
                {
                    photo: '',
                    firstName: '',
                    lastName: '',
                    email: '',
                    phoneNumber: ''
                },
                {
                    country: '',
                    region: '',
                    street: ''
                },
                {
                    position: '',
                    dateOfBirth: '',
                    skills: '',
                    hobbies: '',
                    selfDescription: ''
                },
                {
                    language: '',
                    level: ''
                },
            ],
            experiences: [],
            educations: []
        }
    },
    getters: {
        getSectionNo: state => {
            return state.freelance.sectionNo;
        },
        getComponent1Data: state => {
            return state.components[0];
        },
        getComponent2Data: state => {
            return state.components[1];
        },
        getComponent3Data: state => {
            return state.components[2];
        },
        getComponent4Data: state => {
            return state.components[3];
        },
        getComponent5Data: state => {
            return state.experiences;
        },  
        getComponent6Data: state => {
            return state.educations;
        }
    },
    mutations: {
        setSectionNo(state, payload) {
            state.freelance.sectionNo = payload;
        },
        setComponent1Data(state, payload) {
            state.components[0] = payload
        },
        setComponent2Data(state, payload) {
            state.components[1] = payload
        },
        setComponent3Data(state, payload) {
            state.components[2] = payload
        },
        setComponent4Data(state, payload) {
            state.components[3] = payload
        },
        setComponent5Data(state, payload) {
            state.experiences.push(payload);
        },
        editComponent5DataById(state, payload) {
            console.log(payload.id + ' ' + payload.obj);
            state.experiences[payload.id].companyName = payload.obj.companyName; 
            state.experiences[payload.id].job = payload.obj.job;
            state.experiences[payload.id].working = payload.obj.working;
            state.experiences[payload.id].from = payload.obj.from;
            state.experiences[payload.id].to = payload.obj.to;
            state.experiences[payload.id].description = payload.obj.description;
        },
        removeComponent5DataById(state, payload) {
            state.experiences.splice(payload, 1);
        },
        setComponent6Data(state, payload) {
            state.educations.push(payload);
        },
        editComponent6DataById(state, payload) {
            state.educations[payload.id].schoolName = payload.obj.schoolName; 
            state.educations[payload.id].degree = payload.obj.degree;
            state.educations[payload.id].typeOfStudy = payload.obj.typeOfStudy;
            state.educations[payload.id].location = payload.obj.location;
            state.educations[payload.id].from = payload.obj.from;
            state.educations[payload.id].to = payload.obj.to;
            state.educations[payload.id].currently = payload.obj.currently;
        },
        removeComponent6DataById(state, payload) {
            state.educations.splice(payload, 1);
        },
    },
    actions: {
        setSectionNo({commit}, payload) {
            commit('setSectionNo', payload);
        },
        setComponent1Data({commit}, payload) {
            commit('setComponent1Data', payload);
        },
        setComponent2Data({commit}, payload) {
            commit('setComponent2Data', payload);
        },
        setComponent3Data({commit}, payload) {
            commit('setComponent3Data', payload);
        },
        setComponent4Data({commit}, payload) {
            commit('setComponent4Data', payload);
        },
        setComponent5Data({commit}, payload) {
            commit('setComponent5Data', payload);
        },
        editComponent5DataById({commit}, payload) {
            commit('editComponent5DataById', payload);
        },
        removeComponent5DataById({commit}, payload) {
            commit('removeComponent5DataById', payload);
        },
        setComponent6Data({commit}, payload) {
            commit('setComponent6Data', payload);
        },
        editComponent6DataById({commit}, payload) {
            commit('editComponent6DataById', payload);
        },
        removeComponent6DataById({commit}, payload) {
            commit('removeComponent6DataById', payload);
        }
    },
    plugins: [new VuexPersistence().plugin]
});

export default store;