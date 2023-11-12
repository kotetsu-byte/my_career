<template>
    <div class="super-container">
        <div id="container">
            <div class="resume" v-for="(item, index) in resumes" :key="index">
                <div v-if="!item.companyName" @click="openResume(item.id, 'freelance')">
                    <div class="flex-div">
                        <p>{{ item.firstName }}</p>
                        <p>{{ item.lastName }}</p>
                    </div>
                    <div class="flex-div">
                        <p>{{ item.email }}</p>
                        <p>{{ item.phoneNumber }}</p>
                    </div>
                </div>
                <div v-else @click="openResume(item.id, 'company')">
                    <p>{{ item.companyName }}</p>
                    <p>{{ item.companyPhoneNumber }}</p>
                    <p>{{ item.address }}</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import API from '../api';
import {mapGetters, mapActions} from 'vuex';

export default {
    name: 'MyResumes',
    components: {},
    data() {
        return {
            userId: 0,
            resumes: [

            ],
        }
    },
    props: {

    },
    methods: {
        ...mapActions(['setOpenResume']),
        openResume(id, type) {
            let resume;
            switch(type) {
                case 'freelance':
                    resume = this.resumes.find(item => (!item.companyName) && (item.id === id));
                    break;
                case 'company':
                    resume = this.resumes.find(item => (item.companyName) && (item.id === id));
                    break;
            }
            var obj = {
                id: resume.id,
                type: type
            }
            this.setOpenResume(obj);
            this.$router.push('/open-resume');
        },
    },
    watch: {

    },
    computed: {
        ...mapGetters(['getCurrentUser']),
        receiveFromServer() {
            this.userId = this.getCurrentUser
            console.log(this.userId);
            API.get(`/api/Resume/all/${this.userId}`)
                .then(res => {
                    console.log(res.data);
                    res.data.forEach(elem => {
                        this.resumes.push(elem);
                    });
                })
                .catch(err => {
                    console.log(err);
                });
            // API.get(`/api/CompanyResume/${this.userEmail}`)
            //     .then(res => {
            //         console.log(res.data);
            //         this.resumes.push(this.resumes);
            //     })
        }
    },
    mounted() {
        this.receiveFromServer;
    }
}
</script>

<style scoped>
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}
.super-container {
    padding-top: 200px;
    width: 100%;
    background: url(../assets/img/logo.png) no-repeat;
    height: 100vh;
}

#container {
    width: 50%;
    margin: auto;
}

.resume {
    padding: 10px;
    background: white;
    border-radius: 15px;
    border: 1px solid grey;
}
</style>