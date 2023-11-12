import Vuex from 'vuex';
import VuexPersistence from 'vuex-persist';

const store = new Vuex.Store({
    state() {
        return {
            currentUser: {
                id: 0
            },
            openResume: {
                id: 0,
                type: ''
            },
            isUpdate: false,
            updateResumeId: 0,
            updateEducationId: [],
            updateExpeirenceId: [],
            updateLanguageId: [],
            updateCompanyResumeId: 0,
            freelance: {
                sectionNo: 1,
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
                        website: '',
                        whatsapp: '',
                        facebook: '',
                        instagram: '',
                        telegram: '',
                        github: '',
                        twitter: ''
                    },
                    {
                        selectedTemplate: 0
                    }
                ],
                languages: [],
                experiences: [],
                educations: []
            },
            company: {
                sectionNo: 1,
                components: [
                    {
                        firstName: '',
                        lastName: '',
                        email: '',
                        phoneNumber: ''
                    },
                    {
                        photo: '',
                        companyName: '',
                        companyPhoneNumber: ''
                    },
                    {
                        address: '',
                        description: ''
                    },
                    {
                        website: '',
                        whatsapp: '',
                        facebook: '',
                        instagram: '',
                        telegram: '',
                        github: '',
                        twitter: ''
                    },
                    {
                        selectedTemplate: 0
                    }
                ],
            }
        }
    },
    getters: {
        // user
        getCurrentUser: state => {
            return state.currentUser.id;
        },
        // open resume 
        getOpenResume: state => {
            return state.openResume;
        },
        // update
        getIsUpdate: state => {
            return state.isUpdate;
        },
        // update resume id
        getUpdateResumeId: state => {
            return state.updateResumeId;
        },
        // update education id
        getUpdateEducationId: state => {
            return state.updateEducationId;
        },
        // update experience id 
        getUpdateExperienceId: state => {
            return state.updateExpeirenceId;
        },
        // update language id
        getUpdateLanguageId: state => {
            return state.updateLanguageId;
        },
        // update company resume id
        getUpdateCompanyResumeId: state => {
            return state.updateCompanyResumeId;
        },
        // freelance
        getSectionNo: state => {
            return state.freelance.sectionNo;
        },
        getComponent1Data: state => {
            return state.freelance.components[0];
        },
        getComponent2Data: state => {
            return state.freelance.components[1];
        },
        getComponent3Data: state => {
            return state.freelance.components[2];
        },
        getComponent4Data: state => {
            return state.freelance.languages;
        },
        getComponent5Data: state => {
            return state.freelance.experiences;
        },  
        getComponent6Data: state => {
            return state.freelance.educations;
        },
        getComponent7Data: state => {
            return state.freelance.components[3];
        },
        getComponent8Data: state => {
            return state.freelance.components[4];
        },
        // company
        getCompanySectionNo: state => {
            return state.company.sectionNo;
        },
        getCompanyComponent1Data: state => {
            return state.company.components[0];
        },
        getCompanyComponent2Data: state => {
            return state.company.components[1];
        },
        getCompanyComponent3Data: state => {
            return state.company.components[2];
        },
        getCompanyComponent4Data: state => {
            return state.company.components[3];
        },
        getCompanyComponent5Data: state => {
            return state.company.components[4];
        }
    },
    mutations: {
        // user
        setCurrentUser(state, payload) {
            state.currentUser.id = payload;
        },
        // open resume
        setOpenResume(state, payload) {
            state.openResume = payload;
        },
        // update 
        setIsUpdate(state, payload) {
            state.isUpdate = payload;
        },
        // update resume id
        setUpdateResumeId(state, payload) {
            state.updateResumeId = payload;
            console.log(state.updateResumeId);
        },
        // update education id
        setUpdateEducationId(state, payload) {
            payload.forEach(elem => {
                state.updateEducationId.push(elem);
            });
            console.log(state.updateEducationId);
        },
        // update experience id
        setUpdateExperienceId(state, payload) {
            payload.forEach(elem => {
                state.updateExpeirenceId.push(elem);
            })
            console.log(state.updateExpeirenceId);
        },
        // update language id 
        setUpdateLanguageId(state, payload) {
            payload.forEach(elem => {
                state.updateLanguageId.push(elem);
            })
            console.log(state.updateLanguageId);
        },
        // update company resume id
        setUpdateCompanyResumeId(state, payload) {
            state.updateCompanyResumeId = payload;
        },
        // freelance
        setSectionNo(state, payload) {
            state.freelance.sectionNo = payload;
        },
        setComponent1Data(state, payload) {
            state.freelance.components[0] = payload
        },
        setComponent2Data(state, payload) {
            state.freelance.components[1] = payload
        },
        setComponent3Data(state, payload) {
            state.freelance.components[2] = payload
        },
        setComponent4Data(state, payload) {
            state.freelance.languages = [];
            payload.forEach(elem => {
                state.freelance.languages.push(elem);
            });
            console.log(state.freelance.languages);
        },
        setComponent5Data(state, payload) {
            state.freelance.experiences.push(payload);
        },
        editComponent5DataById(state, payload) {
            console.log(payload.id + ' ' + payload.obj);
            state.freelance.experiences[payload.id].companyName = payload.obj.companyName; 
            state.freelance.experiences[payload.id].job = payload.obj.job;
            state.freelance.experiences[payload.id].working = payload.obj.working;
            state.freelance.experiences[payload.id].from = payload.obj.from;
            state.freelance.experiences[payload.id].to = payload.obj.to;
            state.freelance.experiences[payload.id].description = payload.obj.description;
        },
        removeComponent5DataById(state, payload) {
            state.freelance.experiences.splice(payload, 1);
        },
        removeAllComponent5Data(state) {
            state.freelance.experiences.length = 0;
        },
        setComponent6Data(state, payload) {
                state.freelance.educations.push(payload);
        },
        editComponent6DataById(state, payload) {
            state.freelance.educations[payload.id].schoolName = payload.obj.schoolName; 
            state.freelance.educations[payload.id].degree = payload.obj.degree;
            state.freelance.educations[payload.id].typeOfStudy = payload.obj.typeOfStudy;
            state.freelance.educations[payload.id].location = payload.obj.location;
            state.freelance.educations[payload.id].from = payload.obj.from;
            state.freelance.educations[payload.id].to = payload.obj.to;
            state.freelance.educations[payload.id].currently = payload.obj.currently;
        },
        removeComponent6DataById(state, payload) {
            state.freelance.educations.splice(payload, 1);
        },
        removeAllComponent6Data(state) {
            state.freelance.educations.length = 0;
        },
        setComponent7Data(state, payload) {
            state.freelance.components[3] = payload;
        },
        setComponent8Data(state, payload) {
            state.freelance.components[4] = payload;
        },
        // company
        setCompanySectionNo(state, payload) {
            state.company.sectionNo = payload;
        },
        setComapnyComponent1Data(state, payload) {
            state.company.components[0] = payload;
        },
        setCompanyComponent2Data(state, payload) {
            state.company.components[1] = payload;
        },
        setCompanyComponent3Data(state, payload) {
            state.company.components[2] = payload;
        },
        setCompanyComponent4Data(state, payload) {
            state.company.components[3] = payload;
        },
        setCompanyComponent5Data(state, payload) {
            state.company.components[4] = payload;
        }
    },
    actions: {
        // user
        setCurrentUser({commit}, payload) {
            commit('setCurrentUser', payload);
        },
        // open resume
        setOpenResume({commit}, payload) {
            commit('setOpenResume', payload);
        },
        // update 
        setIsUpdate({commit}, payload) {
            commit('setIsUpdate', payload);
        },
        // update resume id
        setUpdateResumeId({commit}, payload) {
            commit('setUpdateResumeId', payload);
        },
        // update education id
        setUpdateEducationId({commit}, payload) {
            commit('setUpdateEducationId', payload);
        },
        // update experience id
        setUpdateExperienceId({commit}, payload) {
            commit('setUpdateExperienceId', payload);
        },
        // update language id
        setUpdateLanguageId({commit}, payload) {
            commit('setUpdateLanguageId', payload);
        },
        setUpdateCompanyResumeId({commit}, payload) {
            commit('setUpdateCompanyResumeId', payload);
        },
        // freelance
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
        removeAllComponent5Data({commit}, payload) {
            commit('removeAllComponent5Data', payload);
        },
        setComponent6Data({commit}, payload) {
            commit('setComponent6Data', payload);
        },
        editComponent6DataById({commit}, payload) {
            commit('editComponent6DataById', payload);
        },
        removeComponent6DataById({commit}, payload) {
            commit('removeComponent6DataById', payload);
        },
        removeAllComponent6Data({commit}, payload) {
            commit('removeAllComponent6Data', payload);
        },
        setComponent7Data({commit}, payload) {
            commit('setComponent7Data', payload);
        },
        setComponent8Data({commit}, payload) {
            commit('setComponent8Data', payload);
        },
        // company
        setCompanySectionNo({commit}, payload) {
            commit('setCompanySectionNo', payload);
        },
        setComapnyComponent1Data({commit}, payload) {
            commit('setComapnyComponent1Data', payload);
        },
        setCompanyComponent2Data({commit}, payload) {
            commit('setCompanyComponent2Data', payload);
        },
        setCompanyComponent3Data({commit}, payload) {
            commit('setCompanyComponent3Data', payload);
        },
        setCompanyComponent4Data({commit}, payload) {
            commit('setCompanyComponent4Data', payload);
        },
        setCompanyComponent5Data({commit}, payload) {
            commit('setCompanyComponent5Data', payload);
        },
    },
    plugins: [new VuexPersistence().plugin]
});

export default store;