<template>
    <div class="super-container">
        <div id="content">
            <div @click="createNewResume()" style="background-color: white;">
                <div class="flex-div" style="align-items: center; justify-content: start;">
                    <img src="../assets/icons/select/freelancer.png" alt="">
                    <span>New Resume</span>
                </div>
            </div>
            <br><br>
            <div onclick="location.href = '/my-resumes'" style="background-color: white;">
                <div class="flex-div" style="align-items: center; justify-content: start;">
                    <img src="../assets/icons/select/company.png" alt="">
                    <span>My Resumes</span>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import {mapActions} from 'vuex';

export default {
    name: 'HomePage',
    components: {},
    data() {
        return {
            
        }
    },
    props: {

    },
    methods: {
        ...mapActions([
            'setIsUpdate',
            'setSectionNo',
            'setComponent1Data',
            'setComponent2Data',
            'setComponent3Data',
            'setComponent4Data',
            'removeAllComponent5Data',
            'removeAllComponent6Data',
            'setComponent7Data',
            'setComponent8Data',
            'setCompanySectionNo',
            'setComapnyComponent1Data',
            'setComapnyComponent2Data',
            'setComapnyComponent3Data',
            'setComapnyComponent4Data',
            'setComapnyComponent5Data'
        ]),
        createNewResume() {
            this.setComponent1Data({
                photo: '',
                firstName: '',
                lastName: '',
                email: '',
                phoneNumber: ''
            });
            this.setComponent2Data({
                country: '',
                region: '',
                street: ''
            });
            this.setComponent3Data({
                position: '',
                dateOfBirth: '',
                skills: '',
                hobbies: '',
                selfDescription: ''});
            this.setComponent4Data([]);
            this.removeAllComponent5Data();
            this.removeAllComponent6Data();
            this.setComponent7Data({
                website: '',
                whatsapp: '',
                facebook: '',
                instagram: '',
                telegram: '',
                github: '',
                twitter: ''
            });
            this.setComponent8Data({
                selectedTemplate: 0
            });
            this.setComapnyComponent1Data({
                firstName: '',
                lastName: '',
                email: '',
                phoneNumber: ''
            });
            this.setComapnyComponent2Data({
                photo: '',
                companyName: '',
                companyPhoneNumber: ''
            });
            this.setComapnyComponent3Data({
                address: '',
                description: ''
            });
            this.setComapnyComponent4Data({
                website: '',
                whatsapp: '',
                facebook: '',
                instagram: '',
                telegram: '',
                github: '',
                twitter: ''
            });
            this.setComapnyComponent5Data({
                selectedTemplate: 0
            });
            this.$router.push('/resume-type');
            this.setSectionNo(1);
            this.setCompanySectionNo(1);
            this.setIsUpdate(false);
        }
    },
    watch: {

    },
    computed: {

    },
    mounted() {

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

#content {
    margin-top: 100px;
    margin-left: 100px;
    width: 400px;
}

#content > div {
    padding: 10px;
    background: white;
    border-radius: 15px;
}
</style>