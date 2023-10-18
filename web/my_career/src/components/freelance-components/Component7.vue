<template>
    <div class="container">
        <p>Contacts</p>
        <input type="url" name="" id="" placeholder="Provide a link to your website ">
        <p>Choose in which of these social networks you have an account</p>
        <div class="grid-div">
            <div><img src="../../assets/icons/contacts/whatsapp.png" alt=""><p>WhatsApp</p></div>
            <div><img src="../../assets/icons/contacts/facebook.png" alt=""><p>Facebook</p></div>
            <div><img src="../../assets/icons/contacts/instagram.png" alt=""><p>Instagram</p></div>
            <div><img src="../../assets/icons/contacts/telegram.png" alt=""><p>Telegram</p></div>
            <div><img src="../../assets/icons/contacts/github.png" alt=""><p>Github</p></div>
            <div><img src="../../assets/icons/contacts/twitter.png" alt=""><p>Twitter</p></div>
        </div>
        <div style="text-align: right;">
            <button @click="prev(6)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
            <button @click="next(8)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component7',
    components: {},
    props: {
        
    },
    data() {
        return {
            
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
</style>