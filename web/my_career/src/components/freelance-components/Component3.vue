<template>
    <p class="f-30-w-700">Write a little about yourself</p>
    <div class="flex-div">
        <div class="mr-10">
            <label for=""><span class="f-18-w-500">Write your position*</span></label><br>
            <input class="input w-80" type="text" v-model="position" style="">
        </div>
        <div>
            <label for=""><span class="f-18-w-500">Date of birth*</span></label><br>
            <input class="input w-77-5" type="date" v-model="dateOfBirth">
        </div>
    </div>
    <label for=""><span class="f-18-w-500">Write down your skills*</span></label><br>
    <input class="input w-90" type="text" v-model="skills"><br>
    <label for=""><span class="f-18-w-500">Hobbies</span></label><br>
    <input class="input w-90" type="text" v-model="hobbies"><br>
    <textarea class="textarea" v-model="selfDescription" cols="30" rows="10" placeholder="Describe yourself to buyers"></textarea>
</template>

<script>
import {mapActions, mapGetters} from 'vuex';

export default {
    name: 'Component3',
    components: {},
    data() {
        return {
            position: '',
            dateOfBirth: '',
            skills: '',
            hobbies: '',
            selfDescription: ''
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        ...mapActions(['setComponent3Data']),
        sendComponentDataToStore() {
            var obj = {
                position: this.position,
                dateOfBirth: this.dateOfBirth,
                skills: this.skills,
                hobbies: this.hobbies,
                selfDescription: this.selfDescription
            };
            this.setComponent3Data(obj);
            this.$emit('nextPrevPage', null);
        }
    },
    watch: {
        saveToStore: function(newVal, oldVal) {
            if(newVal == true) {
                this.sendComponentDataToStore();
            }
        }
    },
    computed: {
        ...mapGetters(['getComponent3Data']),
        getComponentData() {
            this.position = this.getComponent3Data.position;
            this.dateOfBirth = this.getComponent3Data.dateOfBirth;
            this.skills = this.getComponent3Data.skills;
            this.hobbies = this.getComponent3Data.hobbies;
            this.selfDescription = this.getComponent3Data.selfDescription;
        }
    },
    mounted() {
        this.getComponentData;
    }
}
</script>

<style scoped>
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: max-content;
    max-width: 500px;
}

.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
}

.f-30-w-700 {
    font-size: 30px; 
    font-weight: 700;
}

.mr-10 {
    margin-right: 10px;
}

.f-18-w-500 {
    font-size: 18px; 
    font-weight: 500;
}

.input {
    padding: 15px 20px; 
    border-radius: 8px; 
    border: 1px solid #CDCDCD; 
    font-size: 20px; 
    font-weight: 500; 
}

.w-80 {
    width: 80%;
}

.w-77-5 {
    width: 77.5%;
}

.w-90 {
    width: 90%;
}

.textarea {
    padding: 15px 20px; 
    border-radius: 8px; 
    border: 1px solid #CDCDCD; 
    font-size: 20px; 
    font-weight: 500; 
    width: 90%; 
    height: 200px; 
    resize: none; 
    margin-top: 5px;
}
</style>