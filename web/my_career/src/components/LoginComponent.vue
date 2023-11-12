<template>
    <div id="container">
        <p style="font-size: 30px; font-weight: 700; margin: 5px 0;">Log in</p>
        <p style="font-size: 18px; font-weight: 500; margin: 10px 0;">Still don't have an account? <RouterLink to="/register">Sign up Now</RouterLink></p>
        <input v-model="email" type="email" placeholder="Email" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <input v-model="password" type="password" placeholder="Password" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <div style="text-align: right;">
            <button @click="login" style="padding: 10px 20px; color: white; border: none; border-radius: 8px; background-color: #1D71B8; margin: 10px 0; font-size: 20px; font-weight: 500;">Continue</button>
        </div>
        <p>{{ notification }}</p>
        <hr style="margin: 10px 0;">
        <p style="margin: 5px; text-align: center; font-size: 18px; font-weight: 500; color: #808080;">Or continue with</p>
        <div style="text-align: center;">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/facebook.png" alt="Facebook">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/github.png" alt="Github">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/google.png" alt="Google">
            <img src="../assets/icons/outer-register/apple.png" alt="Apple">
        </div>
    </div>
</template>

<script>
import API from '../api';
import {mapActions} from 'vuex';

export default {
    name: 'LoginComponent',
    components: {},
    data() {
        return {
            email: '',
            password: '',
            notification: ''
        }
    },
    methods: {
        ...mapActions(['setCurrentUser']),
        login() {
            var obj = {
                email: this.email,
                password: this.password
            };
            API.post('/api/User/login', obj)
                .then(res => {
                    if(res.data != false) {
                        this.storeCurrentUser(res.data);
                        this.$router.push('/home');
                    } else {
                        this.notification = 'User not found!';
                    }
                })
                .catch(err => {
                    console.log(err);
                })
        },
        storeCurrentUser(id) {
            this.setCurrentUser(id);
        }
    }
}
</script>

<style scoped>
#container {
    margin: 200px auto;
    width: 400px;
    padding: 30px;
    background: white;
    border-radius: 15px;
}
</style>