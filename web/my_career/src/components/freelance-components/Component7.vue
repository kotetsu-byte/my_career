<template>
    <p style="font-size: 30px; font-weight: 700;">Contacts</p>
    <input type="url" style="border: 1px solid #CDCDCD; padding: 15px 20px; width: 90%; border-radius: 8px; font-size: 20px; font-weight: 500; margin: 10px 0;" placeholder="Provide a link to your website ">
    <p style="font-size: 18px; font-weight: 500; margin: 10px 0;">Choose in which of these social networks you have an account</p>
    <div class="grid-div" style="margin: 10px 0;">
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/whatsapp.png" alt=""><p style="font-size: 20px; font-weight: 600;">WhatsApp</p></div>
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/facebook.png" alt=""><p style="font-size: 20px; font-weight: 600;">Facebook</p></div>
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/instagram.png" alt=""><p style="font-size: 20px; font-weight: 600;">Instagram</p></div>
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/telegram.png" alt=""><p style="font-size: 20px; font-weight: 600;">Telegram</p></div>
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/github.png" alt=""><p style="font-size: 20px; font-weight: 600;">Github</p></div>
        <div style="text-align: center; padding: 30px 44px; border-radius: 8px; box-shadow: 0px 2px 6px 0px rgba(0, 0, 0, 0.25);"><img src="../../assets/icons/contacts/twitter.png" alt=""><p style="font-size: 20px; font-weight: 600;">Twitter</p></div>
    </div>
</template>

<script>

export default {
    name: 'Component7',
    components: {},
    data() {
        return {
            
        }
    },
    props: {
        saveToStore: Boolean
    },
    methods: {
        sendComponentDataToStore() {
            var obj = {
                photo: this.photo,
                firstName: this.firstName,
                lastName: this.lastName,
                email: this.email,
                phoneNumber: this.phoneNumber
            };
            this.setComponent1Data(obj);
            this.$emit('nextPage', null);
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

.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    gap: 6px;
}
</style>