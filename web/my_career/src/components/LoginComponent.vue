<template>
    <div id="container">
        <p style="font-size: 30px; font-weight: 700; margin: 5px 0;">Log in</p>
        <p style="font-size: 18px; font-weight: 500; margin: 10px 0;">Still don't have an account? <a href="">Sign up Now</a></p>
        <input type="email" placeholder="Email" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <input type="password" placeholder="Password" style="width: 90%; padding: 15px 20px; border: 1px solid #CDCDCD; margin-bottom: 5px; border-radius: 8px; font-size: 20px; font-weight: 500;"><br>
        <div style="text-align: right;">
            <button onclick="location.href = '/resume-type'" style="padding: 10px 20px; color: white; border: none; border-radius: 8px; background-color: #1D71B8; margin: 10px 0; font-size: 20px; font-weight: 500;">Continue</button>
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
</template>

<script>
export default {
    name: 'LoginComponent',
    components: {},
    data() {
        return {

        }
    },
    methods: {
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