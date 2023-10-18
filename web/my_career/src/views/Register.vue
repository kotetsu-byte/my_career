<template>
    <div class="flex-div">
        <div id="left">
            <RegisterComponent />
        </div>
        <div id="right">
            
        </div>
    </div>
</template>

<script>
import RegisterComponent from '../components/RegisterComponent.vue';

export default {
    name: 'Register',
    components: {RegisterComponent},
    data() {
        return {
            email: '',
            password: '',
            confirmPassword: ''
        }
    },
    methods: {

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

#left {
    width: 49%;
    background: url(../assets/img/logo.png) no-repeat;
    background-size: contain;
    height: 100vh;
}

#right {
    height: 100vh;
    width: 49%;
    background: url(../assets/img/templates.png) no-repeat;
    background-size: cover;
}
</style>