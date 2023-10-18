<template>
    <button>Back to log in</button>
    <div class="container" id="1">
        <p>Welcome</p>
        <div class="flex-div">
            <div>
                <label for="">First name*</label><br>
                <input type="text">
            </div>
            <div>
                <label for="">Last name*</label><br>
                <input type="text">
            </div>
        </div>
        <div class="flex-div">
            <div>
                <label for="">E-mail*</label><br>
                <input type="email" name="" id="">
            </div>
            <div>
                <label for="">Phone number*</label><br>
                <input type="tel">
            </div>
        </div>
        <button>Next</button>
    </div>
    <div class="container" id="2">
        <p>Your company!</p>
        <img src="../assets/icons/photo/photo.png" alt="">
        <p>Add your company photo</p>
        <label for="">Company name</label><br>
        <input type="text"><br>
        <label for="">Number</label><br>
        <input type="text"><br>
        <button>Back</button>
        <button>Next</button>
    </div>
    <div class="container" id="3">
        <p>About your company</p>
        <p>Write down some more information about your company</p>
        <label for="">Location*</label><br>
        <input type="text"><br>
        <label for="">Description</label><br>
        <input type="text"><br>
        <button>Back</button>
        <button>Next</button>
    </div>
    <div class="container" id="4">
        <p>Contacts</p>
        <input type="url" name="" id="" placeholder="Provide a link to your website ">
        <p>Choose in which of these social networks you have an account</p>
        <div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
            <div></div>
        </div>
        <button>Back</button>
        <button>Next</button>
    </div>
</template>

<script>
export default {
    name: 'Company',
    components: {}
}
</script>

<style scoped>
.container {
    margin: 300px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
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
</style>