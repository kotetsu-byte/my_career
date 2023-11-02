<template>
    <div id="container-1">
        <p style="font-size: 30px; font-weight: 700; margin: 5px 0;">Sign up</p>
        <p style="font-size: 18px; font-weight: 500; margin: 10px 0;">Do you have an account? <a href="">Log in Now</a></p>
        <input type="email" placeholder="Email" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <input type="password" placeholder="Password" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <input type="password" placeholder="Confirm password" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <div style="text-align: right;">
            <button @click="displayEmail()" style="padding: 10px 20px; color: white; border: none; border-radius: 8px; background-color: #1D71B8; margin: 10px 0; font-size: 20px; font-weight: 500;">Continue</button>
        </div>
        <hr style="margin: 10px 0;">
        <p style="margin: 5px; text-align: center; font-size: 18px; font-weight: 500; color: #808080;">Or continue with</p>
        <div style="text-align: center;">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/facebook.png" alt="Facebook">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/github.png" alt="Github">
            <img style="margin-right: 20px;" src="../assets/icons/outer-register/google.png" alt="Google">
            <img src="../assets/icons/outer-register/apple.png" alt="Apple">
        </div>
    </div>
    <div id="container-2">
        <p style="text-align: center; font-size: 30px; font-weight: 700;">Check your email</p>
        <div style="text-align: center;">
            <img src="../assets/img/email.png" alt="Email">
        </div>
        <p style="font-size: 18px; font-weight: 500; color: #808080;">Check your qwerty123@gmail.com inbox for instructions from us on how to verify your account.</p>
        <hr style="margin: 10px 0;">
        <p style="text-align: center;">
            <RouterLink to="/login" style="font-size: 20px; font-weight: 500; text-decoration: none; color: #1D71B8;">Go to login screen</RouterLink>
        </p>
    </div>
</template>

<script>
export default {
    name: 'RegisterComponent',
    components: {},
    data() {
        return {

        }
    },
    methods: {
        displayEmail() {
            var container1 = document.getElementById("container-1");
            var container2 = document.getElementById("container-2");
            container1.style.display = 'none';
            container2.style.display = 'block';
        }
    }
}
</script>

<style scoped>
#container-1 {
    margin: 200px auto;
    width: 400px;
    padding: 30px;
    background: white;
    border-radius: 15px;
}
#container-2 {
    display: none;
    margin: 200px auto;
    width: 400px;
    padding: 30px;
    background: white;
    border-radius: 15px;
}
</style>